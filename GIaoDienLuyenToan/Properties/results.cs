namespace GIaoDienLuyenToan.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class results
    {
        [Key]
        public int result_id { get; set; }

        public int? user_id { get; set; }

        public int score { get; set; }

        public int total_questions { get; set; }

        public int correct_answers { get; set; }

        public int play_time { get; set; }

        public DateTime? played_at { get; set; }

        public virtual users users { get; set; }
    }
}
