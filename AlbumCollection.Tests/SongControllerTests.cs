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
        public void Check_If_Song_Was_Created()  
        {
            var expectedModel = new Song();

            var result = underTest.Create();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Check_If_Song_Was_Posted()  
        {
            var expectedModel = new List<Song>();
            songRepo.GetAll().Returns(expectedModel);
        }
    }
}
