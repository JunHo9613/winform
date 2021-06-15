using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Class1
    {
        public static void Main()
        {
            
            attendTime at = new attendTime();
            at.MakeMessage();


            leaveTime lv = new leaveTime();
            at.MakeMessage();
        }

        /// <summary>
        /// 모든 시간의 부모클래스
        /// </summary>
        public abstract class TimeStamp
        {
            private DateTime DT;

            public TimeStamp()
            {

            }

            public abstract void MakeMessage();
        }


        /// <summary>
        /// 출근시간 클래스
        /// </summary>
        public class attendTime : TimeStamp
        {
            private DateTime ATTime;

            public attendTime()
            {
                ATTime = DateTime.Now;
            }

            /// <summary>
            /// 부모클래스의 MakeMessage() 메서드 다형성
            /// </summary>
            public override void MakeMessage()
            {
                Console.WriteLine($"출근   {ATTime}");
            }
        }

        /// <summary>
        /// 퇴근시간 클래스
        /// </summary>
        public class leaveTime : TimeStamp
        {
            private DateTime LVTime;

            public leaveTime()
            {
                LVTime = DateTime.Now;
            }

            /// <summary>
            /// 부모클래스의 MakeMessage() 메서드 다형성
            /// </summary>
            public override void MakeMessage()
            {
                Console.WriteLine($"퇴근   {LVTime}");
            }
        }

    }
}
