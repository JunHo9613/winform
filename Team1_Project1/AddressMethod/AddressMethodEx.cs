using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressMethod
{
    class Address
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }

        public void showInfo(int order)
        {
            Console.WriteLine("\n-----{0}-----", order);
            Console.WriteLine(" 이름 : " + this.Name);
            Console.WriteLine(" 전화 : " + this.Phone);
            Console.WriteLine(" 주소 : " + this.Addr);
        }

        public void showInfo()
        {
            
            Console.WriteLine(" 이름 : " + this.Name);
            Console.WriteLine(" 전화 : " + this.Phone);
            Console.WriteLine(" 주소 : " + this.Addr);
        }

    }
  
    class AddressMethodEx
    {
        static ArrayList arrList = new ArrayList();

        static void printMenu()
        {
            Console.WriteLine("=================");
            Console.WriteLine("1. 주소 입력");
            Console.WriteLine("2. 주소 검색");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 주소 삭제");
            Console.WriteLine("5. 주소 전체 출력");
            Console.WriteLine("6. App 종료");
            Console.WriteLine("=================");
        }

        static int selectMenu()
        {
            int sel = 0;

            Console.Write("메뉴 선택 >> ");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }

        static void insertAddress()
        {
            Console.WriteLine("---주소 입력---");
            Console.Write("이름 입력 >> ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 >> ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 >> ");
            string addr = Console.ReadLine();

            Address address = new Address();
            address.Name = name;
            address.Phone = phone;
            address.Addr = addr;
            arrList.Add(address);

        }

        static Address searchAddress(string title)
        {


        }

        

    }
}
