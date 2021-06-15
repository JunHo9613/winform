using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210604_solve
{
    class EmployeeEx
    {
        const int SAVE_REGULAR_EMPLOYEE = 1;
        const int SAVE_TEMP_EMPLOYEE = 2;
        const int SAVE_CONTRACT_EMPLOYEE = 3;
        const int PRINT_ALL_EMPLOYEE = 4;
        const int SAVE_EMPLOYEE_SALARY = 5;
        const int EXIT = 6;
        /*  ArrayList와 공통점과 차이점
            공통점 : 배열 대신 순차적으로 저장할 수 있다
            차이점 : ArrayList는 Object를 저장하므로 뭐든지 저장가능
            List<Employee>는 Employee거나 자식객체만 저장가능*/

        List<Employee> employeeList = new List<Employee>();
        static void showMenu()
        {
            Console.WriteLine("메뉴선택");
            Console.WriteLine("1. 정규직 저장");
            Console.WriteLine("2. 임시직 저장");
            Console.WriteLine("3. 계약직 저장");
            Console.WriteLine("4. 전체 정보 출력");
            Console.WriteLine("5. 월급 계산 출력");
            Console.WriteLine("6. 프로그램 종료");
        }
        static int getSelMenu()
        {
            Console.Write(">");
            int sel = Int32.Parse(Console.ReadLine());
            return sel;
        }
        static void clearScreen()
        {
            Console.Clear();
        }

        static void mainLoop()
        {
            bool isRun = true;
            while (isRun)
            {
                clearScreen();
                showMenu();
                int sel = getSelMenu();

                switch(sel)
                {
                    case SAVE_REGULAR_EMPLOYEE:
                        break;
                    case SAVE_TEMP_EMPLOYEE:
                        break;
                    case SAVE_CONTRACT_EMPLOYEE:
                        break;
                    case PRINT_ALL_EMPLOYEE:
                        break;
                    case SAVE_EMPLOYEE_SALARY:
                        break;
                    case EXIT:
                        isRun = false;
                        break;
                }
            }
        }

        static void SAVEREGULAREMPLOYEE()
        {
            Console.WriteLine("정규직 입력");
            Console.Write("사번 : ");
            string companyNum = Console.ReadLine();
            Console.Write("이름 : ");
            string name = Console.ReadLine();
            Console.Write("이름 : ");
            string strPay = Console.ReadLine();
            int pay = Int32.Parse(strPay);
            Console.Write("보너스 : ");
            string strBouns = Console.ReadLine();
            int bouns = Int32.Parse(strBouns);

            RegularEmployee regularEmployee = new RegularEmployee(companyNum, name, pay, bouns);

        }
        const int SAVETEMPEMPLOYEE = 2;
        const int SAVECONTRACTEMPLOYEE = 3;
        const int printALLEMPLOYEE = 4;
        const int calcEMPLOYEESALARY = 5;
        const int EXIT = 6;
        static void Main(string[] args)
        {
            mainLoop();
        }
    }
}
