namespace GIaoDienLuyenToan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameResults
    {
        [Key]
        public int result_id { get; set; }

        [StringLength(50)]
        public string user_id { get; set; }

        public int score { get; set; }

        public int total_questions { get; set; }

        public int correct_answers { get; set; }

        public int incorrect_answers { get; set; }

        public string SelectedAnswers { get; set; }

        public DateTime? played_at { get; set; }

        public virtual users users { get; set; }
    }
}
