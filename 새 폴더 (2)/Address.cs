using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class Address
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }

        public void showInfo(int order)
        {
            Console.WriteLine("\n------{0}------", order);
            Console.WriteLine("이름 : " + this.Name);
            Console.WriteLine("전화 : " + this.Phone);
            Console.WriteLine("주소 : " + this.Addr);
        }
        public void showInfo()
        {
            Console.WriteLine("이름 : " + this.Name);
            Console.WriteLine("전화 : " + this.Phone);
            Console.WriteLine("주소 : " + this.Addr);
        }
    }
}
