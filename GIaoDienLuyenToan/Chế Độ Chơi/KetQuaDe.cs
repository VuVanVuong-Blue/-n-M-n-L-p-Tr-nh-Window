using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIaoDienLuyenToan.Chế_Độ_Chơi
{
    public partial class KetQuaDe : Form
    {
        public string UserId { get; set; }

        public KetQuaDe()
        {
            InitializeComponent();
        }



        private void LoadResults(string userId)
        {
            using (var context = new sqlQuanLyLuyenToan())
            {
                var latestResult = context.GameResults
                                          .Where(r => r.user_id == userId)
                                          .OrderByDescending(r => r.played_at)
                                          .FirstOrDefault();

                if (latestResult != null)
                {
                    // Hiển thị thông tin thành tích
                    txtDung.Text = latestResult.correct_answers.ToString();
                    txtSai.Text = latestResult.incorrect_answers.ToString();
                    txtKL.Text = latestResult.correct_answers.ToString();

                    // Hiển thị danh sách câu hỏi
                    dgvBangKetQua.Rows.Clear();
                    var questions = context.Questions.Take(latestResult.total_questions).ToList();

                    foreach (var q in questions)
                    {
                        dgvBangKetQua.Rows.Add(
                            q.QuestionText, // Câu hỏi
                            "N/A",          // Đáp án chọn (nếu không lưu thông tin này)
                            q.CorrectAnswer // Đáp án đúng
                        );
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void KetQuaDe_Load(object sender, EventArgs e)
        {
            LoadResults(UserId); // Hiển thị kết quả khi form được load
        }

        private void pExit_Click(object sender, EventArgs e)
        {
            GiaoDien gb = new GiaoDien();
            gb.ShowDialog();
            this.Hide();
        }
    }
}
