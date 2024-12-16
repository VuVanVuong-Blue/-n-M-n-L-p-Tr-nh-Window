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
    public partial class QuênMậtKhẩu : Form
    {
        public QuênMậtKhẩu()
        {
            InitializeComponent();
            lbLaymk.Text = "";
        }

        private void btnLayMK_Click(object sender, EventArgs e)
        {
            string em = txtemail.Text;
            if (string.IsNullOrWhiteSpace(em))
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var context = new sqlQuanLyLuyenToan())
            {
                // Tìm kiếm người dùng qua email
                var user = context.users.FirstOrDefault(u => u.email == em);

                if (user != null)
                {
                    lbLaymk.ForeColor = Color.Green;
                    lbLaymk.Text = "Mật khẩu: " + user.password; // Lưu ý: không hiển thị mật khẩu gốc trong thực tế
                }
                else
                {
                    lbLaymk.ForeColor = Color.Red;
                    lbLaymk.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            ĐăngNhập dn = new ĐăngNhập();
            dn.ShowDialog();
            this.Hide();
        }
    }
}
