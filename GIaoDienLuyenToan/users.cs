namespace GIaoDienLuyenToan
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public users()
        {
            GameResults = new HashSet<GameResults>();
        }

        [Key]
        [StringLength(50)]
        public string user_id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string password { get; set; }

        [StringLength(50)]
        public string player_name { get; set; }

        public DateTime? created_at { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GameResults> GameResults { get; set; }
    }
}
