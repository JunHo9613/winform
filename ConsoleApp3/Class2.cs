using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class NowTime
    {
        public static DateTime Now { get; }
 
        //string attend, lie;

        public string inwork()
        {
            string inwork;

            Console.WriteLine("출근?");
            inwork = Console.ReadLine()
        }
        /*public static string Inwork
        {
            get { return this.inwork; }
            set { DateTime.Now.ToString(value, inwork); }
        }*/

 
        
    }
    class ex
    {
        static void Main(string[] args)
        {
            NowTime nt = new NowTime();
            nt.inwork = DateTime.Now.ToString();

        }
    }
    class inwork : NowTime
    {
        public inwork()
        {
  

            Console.ReadLine();

            Console.WriteLine("출근", DateTime.Now.ToString());
        }
    }

    class outwork : NowTime
    {
        public outwork()
        {

            Console.WriteLine("출근", DateTime.Now.ToString());
        }
    }

    
}
