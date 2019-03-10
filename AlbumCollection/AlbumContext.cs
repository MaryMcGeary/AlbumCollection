using AlbumCollection.Models;
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
                AlbumName = "Jesus Use Me",
                ArtistName = "The Faith Tones",
                AlbumImageLocation = "Img/TheFaithTones.jpg"
            },
            new Album()
            {
                AlbumId = 2,
                AlbumName = "Mr. Spock's Music From Outer Space",
                ArtistName = "Leonard Nimoy",
                AlbumImageLocation = "Img/LeonardNimoy.jpg"
            },
            new Album()
            {
                AlbumId = 3,
                AlbumName = "Old McDonald Had a Farm",
                ArtistName = "Alan Mills and the Four Shipmates",
                AlbumImageLocation = "Img/AlanMills.jpg"
            }
            );

            modelBuilder.Entity<Song>().HasData(
            new Song()
            {
                SongId = 1,
                SongName = "Exposed"
            },
            new Song()
            {
                SongId = 2,
                SongName = "It's Different Now"
            },
            new Song()
            {
                SongId = 3,
                SongName = "Music to Watch Space Girls By"
            },
            new Song()
            {
                SongId = 4,
                SongName = "Twinkle, Twinkle Little Earth"
            },
            new Song()
            {
                SongId = 5,
                SongName = "I Know an Old Lady"
            },
            new Song()
            {
                SongId = 6,
                SongName = "Froggie Went A-Courtin"
            }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
