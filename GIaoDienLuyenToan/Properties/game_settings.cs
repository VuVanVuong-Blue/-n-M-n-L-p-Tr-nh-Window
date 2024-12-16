namespace GIaoDienLuyenToan.Properties
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class game_settings
    {
        [Key]
        public int setting_id { get; set; }

        [Required]
        [StringLength(100)]
        public string setting_name { get; set; }

        [Required]
        [StringLength(100)]
        public string value { get; set; }

        [StringLength(255)]
        public string description { get; set; }
    }
}
