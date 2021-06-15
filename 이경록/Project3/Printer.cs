using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    interface ROK
    {
        void USB();
        void port();
    }
    class Printer : ROK
    {
       string name, company;
       int Print_num, Paper_Stock;
        
       public void set()
        {
            this.Print_num = 0;
            this.Paper_Stock = 10;
        }
        public void port()
        {
            Console.WriteLine("123.111.111"); 
        }
        public void USB()
        {
            Console.WriteLine("USB 쫒았습니다.");
        }
        public void print()
        {
            if (Paper_Stock > 0)
            {
                Paper_Stock--;
                Console.WriteLine("출력합니다.^^");
            }
            else
                Console.WriteLine("종이 부족");
        }
        public void start()
        {
            port();
            USB();
            print();
        }
    }
   
    class main_class
    {
        static void Main(string[] gdgd)
        {

            Printer print = new Printer();
            print.set();
            print.start();
        }
    }
}
