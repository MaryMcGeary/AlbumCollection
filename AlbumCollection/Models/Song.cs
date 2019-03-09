using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        public int SongId { get; set; }  

        [Display(Name = "Song Name")]
        public string SongName { get; set; } 
    }
}
