using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace DataAccess
{
    public class CursoContext : DbContext
    {
        private string server = ".";
        private string dataBaseName = "CursosBD";
        private string authentication = "true";

        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CourseEntity> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer($"server={server};database={dataBaseName};trusted_connection={authentication}");
            }
        }

    }
}
