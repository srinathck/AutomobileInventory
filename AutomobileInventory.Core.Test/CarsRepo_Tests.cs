using AutomobileInventory.Core.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomobileInventory.Core.Test
{
    [TestClass]
    public class CarsRepo_Tests
    {
        [TestMethod]
        public void GetCars_Test()
        {
            //Arrange
            CarsRepository repo = new CarsRepository(@"..\..\..\carsData.json");

            //Act
            var cars = repo.GetCars();

            //Assert
            Assert.IsNotNull(cars);
        }

        [TestMethod]
        public void GetCar_Test()
        {
            //Arrange
            CarsRepository repo = new CarsRepository(@"..\..\..\carsData.json");

            //Act
            var cars = repo.GetCar(2);

            //Assert
            Assert.IsNotNull(cars);
        }

        [TestMethod, Ignore]
        public void AddCars_Test()
        {
            //Arrange
            CarsRepository repo = new CarsRepository(null);
            Car car = new Car { Id = 2, Make = "Murano", Model = "SL", Year = 2014, Manufacturer = "Nissan" };

            //Act
            var inserted = repo.AddCar(car);

            //Assert
            Assert.IsTrue(inserted);
        }


        [TestMethod, Ignore]
        public void DeleteCar_Test()
        {
            //Arrange
            CarsRepository repo = new CarsRepository(null);
            Car car = new Car { Id = 2, Make = "Murano", Model = "SL", Year = 2014, Manufacturer = "Nissan" };

            //Act
            var deleted = repo.DeleteCar(car.Id);

            //Assert
            Assert.IsTrue(deleted);
        }


        [TestMethod, Ignore]
        public void UpdateCar_Test()
        {
            //Arrange
            CarsRepository repo = new CarsRepository(null);
            Car car = new Car { Id = 2, Make = "Maxima", Model = "L", Year = 2019, Manufacturer = "Nissan" };

            //Act
            var updated = repo.UpdateCar(car);

            //Assert
            Assert.IsNotNull(updated);
        }
    }
}
