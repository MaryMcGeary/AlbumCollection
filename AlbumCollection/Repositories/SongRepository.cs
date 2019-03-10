using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlbumCollection.Models;

namespace AlbumCollection.Repositories
{
    public class SongRepository : ISongRepository
    {
        AlbumContext db;
        //public SongRepository(AlbumContext db)
        //{
        //    this.db = db;
        //}

        public void Create(Song song)
        {
            db.Songs.Add(song);
            db.SaveChanges();
            //throw new NotImplementedException();
        }

        public IEnumerable<Song> GetAll()
        {
            throw new NotImplementedException();
        }

        public Song GetById(int songId)
        {
            throw new NotImplementedException();
        }
    }
}
