using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal:ICarDal
    //{
    //    List<Car> _cars;
    //    public InMemoryCarDal()
    //    {
    //        _cars = new List<Car> {
    //            new Car{Id=1, BrandId=10, ColorId=2, ModelYear=1998, DailyPrice=20000,Description="-*----"},
    //            new Car{Id=2, BrandId=20, ColorId=4, ModelYear=2005, DailyPrice=50000,Description="---*--"}
    //            new Car{Id=3, BrandId=30, ColorId=6, ModelYear=2010, DailyPrice=100000,Description="--*---"},
    //            new Car{Id=4, BrandId=40, ColorId=8, ModelYear=2020, DailyPrice=500000,Description="-**----"},
    //        };
    //    }
    //    public void Add(Car car)
    //    {
    //        _cars.Add(car);
    //    }

    //    public void Update(Car car)
    //    {
    //        Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
    //        carToUpdate.Id = car.Id;
    //        carToUpdate.BranId = car.BrandId;
    //        carToUpdate.ColorId = car.ColorId;
    //        carToUpdate.ModelYear = car.ModelYear;
    //        carToUpdate.DailyPrice = car.DailyPrice;
    //        carToUpdate.Description = car.Description;


    //    }

    //    public void Delete(Car car)
    //    {
    //        Car carToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);

    //        _cars.Remove(car);
    //    }

    //    public List<Car> GetAll(car)
    //    {
    //        return _cars;
    //    }
    //    public List<Car> GetByld(int Id)
    //    {
    //        return _cars.Where(c => c.Id == Id).ToList();

    //    }

    }

