using System.Collections.Generic;
using Kino.Models;
using Kino.Validators;
using NUnit.Framework;

namespace Kino.Tests
{
    [TestFixture]
    public class Tests
    {
        /*
         * sprawdzenie czy pobranie sal kinowych zwróci listę obiektów typu Hall
         */
        [Test]
        public void GetAllHallsTest()
        {
            var halls = HallValidator.GetAllHalls();
            Assert.True(halls.GetType() == typeof(List<Hall>));
        }

        /*
         * dodanie nowej sali
         */
        [Test]
        public void AddNewHallTest()
        {
            var hall = HallValidator.HallAddValidation("test");
            Assert.True(hall);
            var searchHall = HallValidator.GetHallByName("test");
            Assert.True(searchHall.GetType() == typeof(Hall));
            HallValidator.HallDeleteValidation(searchHall.Id);
        }

        /*
         * zakutalizowanie sali
         */
        [Test]
        public void UpdateHallTest()
        {
            var hall = HallValidator.HallAddValidation("test");
            Assert.True(hall);
            var searchHall = HallValidator.GetHallByName("test");
            Assert.True(searchHall.GetType() == typeof(Hall));
            var updated = HallValidator.HallUpdateValidation(searchHall.Id, "updated");
            Assert.True(updated);
            HallValidator.HallDeleteValidation(searchHall.Id);
        }

        /*
         * usunięcie sali
         */
        [Test]
        public void DeleteHallTest()
        {
            var hall = HallValidator.HallAddValidation("test");
            Assert.True(hall);
            var searchHall = HallValidator.GetHallByName("test");
            Assert.True(searchHall.GetType() == typeof(Hall));
            HallValidator.HallDeleteValidation(searchHall.Id);
            searchHall = HallValidator.GetHallByName("test");
            Assert.Null(searchHall.Name);
        }
    }
}