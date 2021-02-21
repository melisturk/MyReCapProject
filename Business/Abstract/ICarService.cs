﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetCarsByColorId(int colorId);
        List<Car> GetCarsByBrandId(int brandId);

        void Add(Car car);

    }
}
