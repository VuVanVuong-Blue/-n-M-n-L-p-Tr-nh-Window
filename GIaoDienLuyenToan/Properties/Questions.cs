namespace GIaoDienLuyenToan.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questions
    {
        [Key]
        public int QuestionId { get; set; }

        [Required]
        [StringLength(255)]
        public string QuestionText { get; set; }

        [Required]
        [StringLength(50)]
        public string CorrectAnswer { get; set; }

        [StringLength(50)]
        public string Option1 { get; set; }

        [StringLength(50)]
        public string Option2 { get; set; }

        [StringLength(50)]
        public string Option3 { get; set; }

        public int? DifficultyLevel { get; set; }

        [StringLength(50)]
        public string QuestionType { get; set; }
    }
}
