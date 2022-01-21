using fierbinteanu_backend.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Data
{
    public class FierbinteanuContext :  IdentityDbContext<User, Role, int, IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public FierbinteanuContext(DbContextOptions<FierbinteanuContext> options): base(options) { }


        public DbSet<SessionToken> SessionTokens { get; set; }

        public DbSet<Carte> Carti { get; set; }
        public DbSet<Autor> Autori { get; set; }
        public DbSet<Adresa> Adrese { get; set; }
        public DbSet<Premiu> Premii { get; set; }
        public DbSet<CartePremiu> CartiPremii { get; set; }
        public object User { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>(ur =>
            {
                ur.HasKey(ur => new { ur.UserId, ur.RoleId });
                ur.HasOne(ur => ur.Role).WithMany(r => r.UserRole).HasForeignKey(ur => ur.RoleId);
                ur.HasOne(ur => ur.User).WithMany(u => u.UserRole).HasForeignKey(ur => ur.UserId);
            });

            //One to many
            modelBuilder.Entity<Autor>()
                .HasMany(a => a.Carti)
                .WithOne(b => b.Autor);

            //One to one
            modelBuilder.Entity<Autor>()
                .HasOne(a => a.Adresa)
                .WithOne(b => b.Autor)
                .HasForeignKey<Adresa>(c => c.Id);

            //Many to many
            modelBuilder.Entity<CartePremiu>()
                .HasKey(a => new { a.IdCarte, a.IdPremiu });

            modelBuilder.Entity<CartePremiu>()
                .HasOne(a => a.Carte)
                .WithMany(b => b.CartiPremii)
                .HasForeignKey(a => a.IdCarte);

            modelBuilder.Entity<CartePremiu>()
               .HasOne(a => a.Premiu)
               .WithMany(b => b.CartiPremii)
               .HasForeignKey(a => a.IdPremiu);

            base.OnModelCreating(modelBuilder);
        }
    }
}
