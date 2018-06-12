using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkshopManager
{
    interface ImainView
    {
        event Action<bool> loadData;
        event Action<bool> saveData;
        event Func<List<Car>> getAllCars;
        event Func<Car, bool> addNewCar;
        event Func<Car, bool> deleteCar;
        event Func<Car, Car, bool> editCar;

    }
}
