using _98_polymorphism_Address;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressManager
    {
        ArrayList arrList = new ArrayList();
        AddressFile addrFile = new AddressFile();

        public void initAddress() 
        {
            addrFile.loadFileAddress(arrList);
        }
        public void insertAddress() 
        {
            Console.WriteLine("정규직 저장");
            int sel = Int32.Parse(Console.ReadLine());
            string name, phone, pay;

            Address address;

            Console.Write("이름 입력 >> ");
            name = Console.ReadLine();
            Console.Write("전화 입력 >> ");
            phone = Console.ReadLine();
            Console.Write("급여 입력 >> ");
            pay = Console.ReadLine();
            
                address = new Address();
                address.Name = name;
                address.Phone = phone;
                address.Pay = pay;
                arrList.Add(address);
            
            
        }
        public Address searchAddress(string title)
        {
            Console.WriteLine("------{0}------", title);
            Console.Write("검색할 이름 입력 >> ");
            string name = Console.ReadLine();
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                if (address.Name == name)    // 찾았다
                {
                    return address;
                }
            }

            return null;
        }
        public void searchAddress() 
        {
            Address address = searchAddress("주소 검색");
            if (address != null)
                address.showInfo();
            else
                Console.WriteLine("검색 대상이 없습니다...");

            Console.ReadLine();
        }
        public void updateAddress() 
        {
            Address address = searchAddress("주소 수정");
            if (address != null)
            {
                string name, phone, pay;


                Console.Write("수정 이름: ");
                name = Console.ReadLine();
                Console.Write("수정 전화: ");
                phone = Console.ReadLine();
                Console.Write("수정 주소: ");
                pay = Console.ReadLine();

                address.Name = name;
                address.Phone = phone;
                address.Pay = pay;
                                           
                address.showInfo();
            }
            else
                Console.WriteLine("수정 대상이 없습니다...");

            Console.ReadLine();
        }
        public void deleteAddress() 
        {
            Address address = searchAddress("삭제");
            if (address != null)
            {
                address.showInfo();
                Console.Write("정규직");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                    arrList.Remove(address);
                else
                    Console.WriteLine("삭제가 취소되었습니다~");
            }
            else
                Console.WriteLine("삭제 대상이 없습니다...");

            Console.ReadLine();
        }
        public void printAllAddress() 
        {
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                address.showInfo(i + 1);
            }
            Console.ReadLine();
        }
        public void programExit() 
        {
            addrFile.saveFileAddress(arrList);
            Console.Write("프로그램 종료~");
            Console.ReadLine();
        }
    }
}
