using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumCollection.Controllers
{
    public class SongController : Controller
    {
        ISongRepository songRepo;
        //private object album;

        public SongController(ISongRepository songRepo) 
        {
            this.songRepo = songRepo;
        }

        public ViewResult Details(int id)
        {
            Song model = songRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Song song)
        {
            songRepo.Create(song);
            return RedirectToAction("Details/" + song.AlbumId, "Album");
        }

        //private ActionResult RedirectToAction(object p, string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
