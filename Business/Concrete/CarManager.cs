using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            _carDal.Add(car);
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById()
        {
            throw new NotImplementedException();
        }

        public List<Car> GetCarsByBrandId()
        {
            return _carDal.Get(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
