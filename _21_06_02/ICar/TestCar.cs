using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_06_02.ICar
{
    class TestCar
    {
        public ICar Car { get; set; }
        private void endTest(bool isDelay = true, int delayTime = 100)
        {

            Console.WriteLine("==================");
            if (isDelay)
                System.Threading.Thread.Sleep(delayTime);//2147483647
        }

        public void startEngienTest(int count = 3)
        {
            if (Car == null) return;
            for (int i = 0; i < count; i++)
            {
                Car.startEngine();
                endTest();
            }
        }

        public void breakTest(int count = 3)
        {
            if (Car == null) return;
            for (int i = 0; i < count; i++)
            {
                Car.startEngine();
                Car.hitBreak();
                endTest();
            }
        }

        public void drivingTest(int count = 3)
        {
            if (Car == null) return;
            for (int i = 0; i < count; i++)
            {
                Car.startEngine();
                Car.speedUp();
                Car.speedDown();
                Car.hitBreak();
                endTest();
            }
        }
    }
}
