using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GIaoDienLuyenToan
{
    public partial class sqlQuanLyLuyenToan : DbContext
    {
        public sqlQuanLyLuyenToan()
            : base("name=sqlQuanLyLuyenToan")
        {
        }

        public virtual DbSet<GameResults> GameResults { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
