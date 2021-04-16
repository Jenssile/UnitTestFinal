using FinalNUnitTestProject;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace FinalNUnitTestProject.Tests {
    [TestFixture()]
    public class BikeStorageTests {

        public ListOfBikes list = new ListOfBikes();
        [Test()]
        public void CreateTest() {
            BikeStorage bike = new BikeStorage(1, "name", Model.Excelsior);
            BikeStorage.Create(bike, list);

            Assert.That(list.bikeStorages.Contains(bike), Is.EqualTo(true));
        }
    }
}