using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GIaoDienLuyenToan.Properties;

namespace GIaoDienLuyenToan.Quản_Lý_Tài_Khoản
{
    public partial class ĐăngNhập : Form
    {
        public ĐăngNhập()
        {
            InitializeComponent();
        }

        private void ĐăngNhập_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuênMậtKhẩu quenmatkhau = new QuênMậtKhẩu();
            quenmatkhau.Show();
            this.Hide();
        }

        private void linkLabelDangky_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ĐăngKý dangKy = new ĐăngKý();
            dangKy.Show();
            this.Hide();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txttentaikhoan.Text.Trim();
            string mk = txtmatkhau.Text.Trim();

            if (string.IsNullOrWhiteSpace(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mã hóa mật khẩu nhập vào để so sánh
            string hashedPassword = HashPassword(mk);

            using (var context = new sqlQuanLyLuyenToan())
            {
                // Kiểm tra thông tin đăng nhập
                var user = context.users.FirstOrDefault(u => u.username == tentk && u.password == hashedPassword);

                if (user != null)
                {
                    MessageBox.Show("Đăng nhập thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    GiaoDien chuongTrinh = new GiaoDien(user.user_id); // Truyền user_id
                    chuongTrinh.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

    }
}
