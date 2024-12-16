    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using GIaoDienLuyenToan.Chế_Độ_Chơi;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using WinFormsButton = System.Windows.Forms.Button;
namespace GIaoDienLuyenToan
{
        public partial class GiaoDien : Form
        {
    


        public GiaoDien()
            {
                InitializeComponent();
            
            }
    

        private void panel2_Paint(object sender, PaintEventArgs e)
            {

            }

        private void ShowToanCoBan()
        {
            // Tạo instance của ToanCoBanControl
            ToanCoBanForm toanCoBan = new ToanCoBanForm();
    
            // Truyền dữ liệu vào ToanCoBanControl
            toanCoBan.InitializeData("Người chơi A");


        }


        private string LoadPlayerName(string userId)
        {
            using (var context = new sqlQuanLyLuyenToan())
            {
                // Lấy player_name dựa trên user_id
                var user = context.users.FirstOrDefault(u => u.user_id == userId);
                return user?.player_name ?? "Unknown Player";
            }
        }
        private string userId; // Biến lưu trữ user_id

        public GiaoDien(string userId)
        {
            InitializeComponent();
            this.userId = userId; // Lưu user_id được truyền vào
            this.IsMdiContainer = true;

            // Hiển thị tên người chơi
            string playerName = LoadPlayerName(userId);
            lblUser.Text = playerName; // lblUser là nhãn hiển thị tên người chơi
        }

        private void GiaoDien_Load(object sender, EventArgs e)
        {

        }

        private void btnToancoban_Click(object sender, EventArgs e)
        {

            ToanCoBanForm toanCoBanForm = new ToanCoBanForm();
            toanCoBanForm.ShowDialog();

        }
    }
    }
