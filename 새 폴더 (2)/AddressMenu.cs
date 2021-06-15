using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressMenu
    {
        AddressManager addrManager =
            new AddressManager();

        public void mainLoop()
        {
            addrManager.initAddress();

            bool isRun = true;
            while (isRun)
            {
                clearScreen();
                printMenu();
                int sel = selectMenu();

                clearScreen();
                switch (sel)
                {
                    case 1:
                        addrManager.insertAddress();
                        break;
                    case 2:
                        addrManager.searchAddress();
                        break;
                    case 3:
                        addrManager.updateAddress();
                        break;
                    case 4:
                        addrManager.deleteAddress();
                        break;
                    case 5:
                        addrManager.printAllAddress();
                        break;
                    case 6:
                        addrManager.programExit();
                        isRun = false;
                        break;
                    default:
                        break;
                }
            }
        }

        public void printMenu()
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

        public int selectMenu()
        {
            int sel = 0;

            Console.Write("메뉴 선택 >> ");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }

        public static void clearScreen()
        {
            Console.Clear();
        }
    }
}
