using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;

namespace GIaoDienLuyenToan
{
    public partial class Id_Game : Form
    {
        private sqlQuanLyLuyenToan context = new sqlQuanLyLuyenToan(); // DB Context

        public Id_Game()
        {
            InitializeComponent();
        }
        public Id_Game(string userId)
        {
            InitializeComponent(); // Gọi hàm khởi tạo giao diện

            // Thiết lập giá trị mặc định cho TextBox userID
            txtUserId.Text = userId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ TextBox
            string userId = txtUserId.Text.Trim();
            string playerName = txtPlayerName.Text.Trim();

            // Kiểm tra giá trị rỗng
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(playerName))
            {
                MessageBox.Show("User ID và Tên người chơi không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra trùng User ID trong Database
                if (context.users.Any(u => u.user_id == userId))
                {
                    MessageBox.Show("User ID đã tồn tại! Vui lòng nhập ID khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo đối tượng user mới
                var newUser = new users
                {
                    user_id = userId,
                    player_name = playerName,
                    created_at = DateTime.Now
                };

                // Thêm vào DbSet và lưu thay đổi
                context.users.Add(newUser);
                context.SaveChanges();

                MessageBox.Show("Lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form sau khi lưu
            }
            catch (DbEntityValidationException ex)
            {
                // Hiển thị lỗi Entity Framework Validation
                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
