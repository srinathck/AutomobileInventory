﻿using AutomobileInventory.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AutomobileInventory.Core
{
    public class CarsRepository
    {
        private static string path = @"C:\Users\Srinath\source\repos\AutomobileInventory\AutomobileInventory.Core\Data\carsData.json";
        private string json = File.ReadAllText(path);

        public bool AddCar(Car car)
        {
            try
            {
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                cars.Add(car);

                string newJsonResult = JsonConvert.SerializeObject(cars, Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<Car> GetCars()
        {
            try
            {

                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                return cars;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Car GetCar(int id)
        {
            try
            {
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
                return cars.FirstOrDefault(c => c.Id == id);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Car UpdateCar(Car updateCar)
        {
            try
            {
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);

                foreach (var car in cars.Where(c => c.Id == updateCar.Id))
                {
                    car.Manufacturer = updateCar.Manufacturer;
                    car.Model = updateCar.Model;
                    car.Year = updateCar.Year;
                    car.Make = updateCar.Make;
                }

                string newJsonResult = JsonConvert.SerializeObject(cars, Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
                return updateCar;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteCar(int id)
        {
            try
            {
                List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);

                cars.Remove(cars.FirstOrDefault(c => c.Id == id));

                string newJsonResult = JsonConvert.SerializeObject(cars, Formatting.Indented);
                File.WriteAllText(path, newJsonResult);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
