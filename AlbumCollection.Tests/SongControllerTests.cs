using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlbumCollection.Tests
{
    public class SongControllerTests
    {
        SongController underTest;
        private ISongRepository songRepo;

        public SongControllerTests()
        {
            songRepo = Substitute.For<ISongRepository>();
            underTest = new SongController(songRepo); 
        }

        [Fact]
        public void Index_Sets_Model_To_Correct_Song_List() 
        {
            var expectedId = 2;
            var expectedModel = new Song();

            songRepo.GetById(expectedId).Returns(expectedModel);

            var result = underTest.Details(expectedId);
            var model = (Song)result.Model;

            Assert.Equal(expectedModel, model);
        }

        [Fact]
        public void Check_Song_Created()    
        {
            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);
        }

        //public ViewResult Create()
        //{
        //    return View();
        //}

        //[Fact]
        //public void Check_Post_for_Song()
        //{
        //    var songRepo = new SongRepository();
        //    //    var dbMock = MockRepository.GenerateMock<DBService>();

        //    //    var controller = new MyController(dbMock);
        //    //    var result = (RedirectToRouteResult)controller.Add(new Thing());

        //        Assert.IsType<RedirectToAction>("Index") 
        //    //(result.Url, Is.EqualTo("/mynew/url"));

        //}

        //public ActionResult Create(Song song)
        //{
        //    songRepo.Create(song);
        //    return RedirectToAction("Index");
        //}
    }
}
