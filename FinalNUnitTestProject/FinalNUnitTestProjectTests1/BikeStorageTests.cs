using NUnit.Framework;
using FinalNUnitTestProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        [Test()]
        public void DeleteTest() {
            BikeStorage bike = new BikeStorage(1, "name", Model.Excelsior);
            BikeStorage.Create(bike, list);

            BikeStorage.Delete(list, bike);
            Assert.That(list.bikeStorages.Contains(bike), Is.EqualTo(false));
        }

        [Test()]
        public void UpdateTest() {
            BikeStorage bike = new BikeStorage(1, "name", Model.Excelsior);
            BikeStorage.Create(bike, list);

            bike.name = "Testname";
            BikeStorage.Update(list, "name", "Testname");

            Assert.That(list.bikeStorages.Contains(bike), Is.EqualTo(true));
        }

        [Test()]
        public void ReadTest() {
            BikeStorage bike = new BikeStorage(1, "name", Model.Excelsior);
            BikeStorage.Create(bike, list);

            BikeStorage.Read(list);
        }
    }
}