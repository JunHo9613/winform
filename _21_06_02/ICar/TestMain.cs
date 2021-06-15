using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.ICar
{
    class TestMain
    {
        public void Start()
        {
            ICar[] iCarArr = { new ToyotaCar(), new KiaCar(), new HyundaiCar() };

            TestCar testCar = new TestCar();

            foreach (ICar car in iCarArr)
            {
                testCar.Car = car;
                testCar.startEngienTest();
                testCar.breakTest();
                testCar.drivingTest();
            }
        }
    }
}
