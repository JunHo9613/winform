using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 20210602.테스트_클래스
{
    class TestCar
    {
        public ICar Car { get; set; }
        
        private void endTest(bool isDelay=true, int delayTime=100)
        {
            Console.WriteLine("===================");
            if(isDelay)
                System.Threading.Thread.Sleep(delayTime);            
        }

        public void onOffTest(int count = 3)
        {
            if (this.Car == null) return; // 메서드 종료

            for(int i = 0; i < count; i++)
            {
                Car.play();
                Car.startEngine();
                Car.hitbreak();                
                endTest();
            }
        }

        public void speedTest(int count = 3)
        {
            if (this.Car == null) return; // 메서드 종료

            for (int i = 0; i < count; i++)
            {
                Car.play();
                Car.speedUp();
                Car.speedDown();
                endTest();
            }
        }

        public void playTest(int count = 3)
        {
            if (this.Car == null) return; // 메서드 종료

            for (int i = 0; i < count; i++)
            {
                Car.play();
                Car.startEngine();
                Car.speedUp();
                Car.speedDown();
                Car.hitbreak();                             
                endTest();
            }
        }
    }
}
