﻿using AlbumCollection.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection 
{
    public class AlbumContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=MaryAlbums39;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
            new Album()
            {
                AlbumId = 1,
                AlbumName = "Some Album",
                ArtistName = "Not Me",
                AlbumImageLocation = "Somewhere out there"
            }
            );

            modelBuilder.Entity<Song>().HasData(
            new Song()
            {
                SongId = 1,
                SongName = "Yay!"
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
