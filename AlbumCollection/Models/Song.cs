using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Models
{
    public class Song
    {
        public int Id { get; set; }

        [Display(Name = "Song Name")]
        public string Name { get; set; }
    }
}
