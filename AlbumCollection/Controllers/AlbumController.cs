using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class AlbumController : Controller
    {
        IAlbumRepository albumRepo;  

        public AlbumController (IAlbumRepository albumRepo)
        {
            this.albumRepo = albumRepo;
        }

        
    }
}
