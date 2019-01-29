using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Net_Core_3_MsSQL_Codefirst.Entites;
using System;

namespace Net_Core_3_MsSQL_Codefirst.Context
{
    public class MsSQLDbContext : DbContext
    {
        #region Constructor

        public MsSQLDbContext(DbContextOptions<MsSQLDbContext> options)
            : base(options)
        {

        }

        #endregion Constructor

        #region ModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        #endregion ModelCreating

        #region OnConfiguring

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        #endregion OnConfiguring

        #region DbSets

        public DbSet<EntityUser> EntityUser { get; set; }
        public DbSet<EntityRole> EntityRole { get; set; }
        public DbSet<EntityUserRole> EntityUserRole { get; set; }

        #endregion DbSets

    }
}
