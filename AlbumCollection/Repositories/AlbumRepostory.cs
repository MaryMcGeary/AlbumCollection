using AlbumCollection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        AlbumContext db;
        public AlbumRepository(AlbumContext db)
        {
            this.db = db; 
        }

        public IEnumerable<Album> GetAll()
        {
            return db.Albums.ToList();
            //}

            //IEnumerable<int> enumerable = Enumerable.Range(1, 300);
            //List<int> AlbumId = enumerable.ToList(); 
        }
        public Album GetById(int albumId) 
        {
            return db.Albums.Single(album => album.AlbumId == albumId);
        }

        //Album IAlbumRepository.GetById(int albumId)
        //{
        //    return db.Albums.Single(album => album.AlbumId == albumId);
        //}
    }
}
