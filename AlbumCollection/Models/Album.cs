using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Album
    {
        public int AlbumId { get; set; }  
        public int CategoryId { get; set; }

        [Display(Name = "Album Name")]
        public string AlbumName { get; set; } 

        [Display(Name = "Artist Name")]
        public string ArtistName { get; set; }

        [Display(Name = "Album Image URL")]
        public string AlbumImageLocation { get; set; }

        public virtual IEnumerable<Album> Albums { get; set; } 
    }
}
