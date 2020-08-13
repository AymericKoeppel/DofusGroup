using DofusGroup.Shared.FKModels;
using DofusGroup.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DofusGroup.Data.DB
{
    public class DofusContext : DbContext
    {
        public DbSet<Dungeon> Dungeons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<DungeonUser> DungeonUsers { get; set; }
        public DbSet<Class> Class { get; set; }



        public DofusContext(DbContextOptions<DofusContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<Dungeon>().ToTable("Dungeons");
            //modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<DungeonUser>().HasKey(sc => new { sc.DungeonId, sc.UserId });
        }
    }
}
//Add-Migration InitialCreate
//Update-Database