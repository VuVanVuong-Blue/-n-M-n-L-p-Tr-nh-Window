using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GIaoDienLuyenToan.Chế_Độ_Chơi
{
    public partial class ToanCoBanForm : Form
    {
        private string connectionString = @"Server=BLUE;Database=QuanLyLuyenToan;Trusted_Connection=True;";
        private DataTable questions;
        private int currentQuestionIndex = 0;
        private int timeLeft = 60; // Thời gian trả lời (giây)
        private int correctCount = 0;
        private int incorrectCount = 0;
        private Random rand = new Random();


        public string UserName { get; set; }


        public ToanCoBanForm()
        {
            InitializeComponent();
        }
        public void InitializeData(string userName)
        {
            UserName = userName;
            lblWelcome.Text = $"Chào mừng {UserName} đến với trò chơi!";
        }
        private void ToanCoBanForm_Load(object sender, EventArgs e)
        {
            this.Enabled = true; // Đảm bảo form được kích hoạt
            LoadQuestions();
            StartTimer();
        }
        private void LoadQuestions()
        {
            try
            {
                questions = GetQuestions(); // Lấy câu hỏi từ cơ sở dữ liệu
                if (questions.Rows.Count > 0)
                {
                    DisplayQuestion(); // Hiển thị câu hỏi đầu tiên
                }
                else
                {
                    MessageBox.Show("Không tìm thấy câu hỏi nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close(); // Đóng form nếu không có câu hỏi
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải câu hỏi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Đóng form nếu xảy ra lỗi
            }
        }

        private DataTable GetQuestions()
        {
            DataTable dt = new DataTable();
            string query = "SELECT TOP 49 * FROM Questions"; // Lấy 10 câu hỏi từ SQL

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex < questions.Rows.Count)
            {
                DataRow question = questions.Rows[currentQuestionIndex];
                lblQuestion.Text = question["QuestionText"].ToString();

                // Xáo trộn đáp án
                List<string> answers = new List<string>
                {
                    question["CorrectAnswer"].ToString(),
                    question["Option1"].ToString(),
                    question["Option2"].ToString(),
                    question["Option3"].ToString()
                };

                answers = answers.OrderBy(x => rand.Next()).ToList();

                // Gán đáp án cho các nút
                btnOption1.Text = answers[0];
                btnOption2.Text = answers[1];
                btnOption3.Text = answers[2];
                btnOption4.Text = answers[3];

                // Lưu đáp án đúng vào Tag của câu hỏi
                lblQuestion.Tag = question["CorrectAnswer"].ToString();
            }
            else
            {
                EndGame();
            }
        }


        private void CheckAnswer(System.Windows.Forms.Button selectedButton)
        {
            string correctAnswer = lblQuestion.Tag.ToString();
            if (selectedButton.Text == correctAnswer)
            {
                correctCount++;
                lblResult.Text = $"{correctCount}"; // Hiển thị số câu đúng ngay lập tức
                lblResult.ForeColor = Color.Green; // Màu xanh khi đúng
            }
            else
            {
                incorrectCount++;
                lblResult.ForeColor = Color.Red; // Màu đỏ khi sai
            }

            currentQuestionIndex++;
            DisplayQuestion(); // Hiển thị câu hỏi tiếp theo
        }
        
        private void StartTimer()
        {
            ProgressBar.Maximum = timeLeft;
            ProgressBar.Value = timeLeft;
            lblTimer.Text = timeLeft.ToString();
            timerCountdown.Start();
        }
        // hiển bảng KQ
        private void EndGame()
        {
            timerCountdown.Stop();

            // Lưu kết quả vào database
            SaveGameResult(UserName, correctCount, questions.Rows.Count, correctCount * 10, incorrectCount);

            // Mở form kết quả
            KetQuaDe ketQuaDe = new KetQuaDe { UserId = UserName };
            ketQuaDe.ShowDialog();
            this.Close();
        }
        //bảng kết quả
        private void SaveGameResult(string userId, int correctAnswers, int totalQuestions, int score, int incorrectAnswers)
        {
            using (var context = new sqlQuanLyLuyenToan())
            {
                var result = new GameResults
                {
                    user_id = userId,
                    correct_answers = correctAnswers,
                    incorrect_answers = incorrectAnswers,
                    total_questions = totalQuestions,
                    score = score,
                    played_at = DateTime.Now
                };

                context.GameResults.Add(result);
                context.SaveChanges();
            }
        }


        private void DisableButtons()
        {
            btnOption1.Enabled = false;
            btnOption2.Enabled = false;
            btnOption3.Enabled = false;
            btnOption4.Enabled = false;
        }
        private void ShowKetQuaDe()
        {
            KetQuaDe ketQuaDe = new KetQuaDe();
            ketQuaDe.UserId = UserName; // Truyền UserId
            ketQuaDe.ShowDialog();
        }
   






        private void timerCountdown_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                ProgressBar.Value = timeLeft;
                lblTimer.Text = timeLeft.ToString();
            }
            else
            {
                timerCountdown.Stop();
                EndGame(); // Gọi khi hết thời gian
            }
        }
        // Các sự kiện nút trả lời
        private void btnOption1_Click(object sender, EventArgs e) => CheckAnswer((Button)sender);
        private void btnOption2_Click(object sender, EventArgs e) => CheckAnswer((Button)sender);
        private void btnOption3_Click(object sender, EventArgs e) => CheckAnswer((Button)sender);
        private void btnOption4_Click(object sender, EventArgs e) => CheckAnswer((Button)sender);
    }
}
