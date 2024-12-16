using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIaoDienLuyenToan.Properties;

namespace GIaoDienLuyenToan.Quản_Lý_Tài_Khoản
{
    public partial class ĐăngKý : Form
    {
        public ĐăngKý()
        {
            InitializeComponent();
        }

        // Hàm kiểm tra tài khoản hợp lệ
        public bool CheckAccount(string ac)
        {
            // Chỉ cho phép chữ cái và số, độ dài từ 6 đến 24 ký tự
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        // Hàm kiểm tra email hợp lệ
        public bool CheckEmail(string em)
        {
            // Kiểm tra định dạng email @gmail.com hoặc @gmail.com.vn
            return Regex.IsMatch(em, @"^[a-zA-Z0-9._%+-]{3,20}@gmail\.com(\.vn)?$");
        }

        // Hàm mã hóa mật khẩu
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tentk = txttentaikhoan.Text.Trim();
            string mk = txtmatkhau.Text.Trim();
            string xn = txtXNmatkhau.Text.Trim();
            string email = txtemail.Text.Trim();

            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(xn))
            {
                MessageBox.Show("Vui lòng nhập xác nhận mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng tên tài khoản
            if (!CheckAccount(tentk))
            {
                MessageBox.Show("Tên tài khoản phải từ 6 đến 24 ký tự, bao gồm chữ và số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra định dạng mật khẩu
            if (!CheckAccount(mk))
            {
                MessageBox.Show("Mật khẩu phải từ 6 đến 24 ký tự, bao gồm chữ và số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Kiểm tra xác nhận mật khẩu
            if (mk != xn)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email
            if (!CheckEmail(email))
            {
                MessageBox.Show("Email không hợp lệ! Vui lòng nhập email @gmail.com hoặc @gmail.com.vn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new sqlQuanLyLuyenToan())
            {
                // Kiểm tra email đã tồn tại chưa
                if (context.users.Any(u => u.email == email))
                {
                    MessageBox.Show("Email này đã được sử dụng! Vui lòng chọn email khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra tên tài khoản đã tồn tại chưa
                if (context.users.Any(u => u.username == tentk))
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại! Vui lòng chọn tên khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Tạo user_id mới
                string userId = Guid.NewGuid().ToString();

                // Tạo đối tượng người dùng mới
                var newUser = new users
                {
                    user_id = userId,
                    username = tentk,
                    password = HashPassword(mk), // Mã hóa mật khẩu
                    email = email,
                    player_name = null, // Chưa nhập tên người chơi
                    created_at = DateTime.Now
                };

                try
                {
                    // Lưu người dùng vào cơ sở dữ liệu
                    context.users.Add(newUser);
                    context.SaveChanges();

                    // Hỏi người dùng có muốn thêm Tên Người Chơi không
                    if (MessageBox.Show("Đăng ký thành công! Bạn có muốn thêm Tên Người Chơi không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        Id_Game idGameForm = new Id_Game(userId);
                        idGameForm.ShowDialog();

                    }

                    // Chuyển về form đăng nhập
                    ĐăngNhập dn = new ĐăngNhập();
                    dn.Show();
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi chi tiết
                    MessageBox.Show("Có lỗi xảy ra trong quá trình đăng ký: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            ĐăngNhập dn = new ĐăngNhập();
            dn.Show();
            this.Close();
        }
    }
}
