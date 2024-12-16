namespace GIaoDienLuyenToan.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leaderboard")]
    public partial class leaderboard
    {
        [Key]
        public int leaderboard_id { get; set; }

        public int? user_id { get; set; }

        public int score { get; set; }

        public int? rank { get; set; }

        public DateTime? updated_at { get; set; }

        public virtual users users { get; set; }
    }
}
