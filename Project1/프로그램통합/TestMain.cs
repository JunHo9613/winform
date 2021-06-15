using 20210602.구현클래스;
using 20210602.테스트_클래스;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 20210602.프로그램_통합
{
    class TestMain
    {
        static void Main(string[] args)
        {
            ICar[] carArr =
            {
                new HyundaiCar(),
                new KiaCar(),
                new ToyotaCar()
            };

            TestCar testCar = new TestCar();

            foreach(ICar car in carArr)
            {
                testCar.Car = car;
                testCar.onOffTest();
                testCar.speedTest();
                testCar.playTest();
            }
        }
    }
}
