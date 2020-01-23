﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamenOnlineGokken.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExamenOnlineGokken.Data
{
    public class GambleDbContext : DbContext
    {
        //define dbsets here
        public DbSet<League> Leagues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Bet> Bets { get; set; }

        public GambleDbContext(DbContextOptions<GambleDbContext> options):base(options){}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<League>()
                .HasMany(g => g.Games)
                .WithOne(l => l.League)
                .HasForeignKey(g => g.LeagueId);

            modelBuilder.Entity<Bet>()
                .HasKey(b => new { b.GameId, b.UserId });       

            modelBuilder.Entity<Game>()
                .HasMany(g => g.Bets)
                .WithOne(b => b.Game);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Bets)
                .WithOne(b => b.User);
            modelBuilder.Entity<Bet>().Property(b => b.BetAmount).HasColumnType("Decimal");

            Seeder.Seed(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}
