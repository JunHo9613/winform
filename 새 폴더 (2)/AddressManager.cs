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
                Console.Write("수정 이름: ");
                string name = Console.ReadLine();
                Console.Write("수정 전화: ");
                string phone = Console.ReadLine();
                Console.Write("수정 주소: ");
                string addr = Console.ReadLine();
                address.Name = name;
                address.Phone = phone;
                address.Addr = addr;
                address.showInfo();
            }
            else
                Console.WriteLine("수정 대상이 없습니다...");

            Console.ReadLine();
        }
        public void deleteAddress() 
        {
            Address address = searchAddress("주소 삭제");
            if (address != null)
            {
                address.showInfo();
                Console.Write("진짜 삭제하시겠습니까(y/n) >> ");
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
