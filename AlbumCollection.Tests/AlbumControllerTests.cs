using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests 
    {
        AlbumController underTest; 
        private IAlbumRepository albumRepo;

        public AlbumControllerTests() 
        {
            albumRepo = Substitute.For<IAlbumRepository>();
            underTest = new AlbumController(albumRepo);
        }

        [Fact]
        public void Index_Sets_Model_To_All_Albums() 
        {
            var expectedModel = new List<Album>();
            albumRepo.GetAll().Returns(expectedModel);
        }

        //[Fact]
        //public void Details_Sets_Model_To_Correct_Album() 
        //{

        //}
    }
}
