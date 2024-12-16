using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace GIaoDienLuyenToan.Properties
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<admin> admin { get; set; }
        public virtual DbSet<game_settings> game_settings { get; set; }
        public virtual DbSet<leaderboard> leaderboard { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<results> results { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<users> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
