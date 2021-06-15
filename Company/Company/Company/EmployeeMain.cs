using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class EmployeeMain
    {
        const int DEV_EMPLOYEE = 1;
        const int SERVICE_EMPLOYEE = 2;
        const int MARKETING_EMPLOYEE = 3;
        const int INFO_EMPLOYEE = 4;
        const int EMPLOYEE_SALARY = 5;
        const int EXIT = 6;

        static List<Employee> employeeList = new List<Employee>();

        static void showMenu()
        {
            Console.WriteLine("1. 개발직");
            Console.WriteLine("2. 서비스직");
            Console.WriteLine("3. 영업직");
            Console.WriteLine("4. 구성원정보");
            Console.WriteLine("5. 연봉확인");
            Console.WriteLine("6. 나가기");
        }

        static int getSelMenu()
        {
            Console.Write(">> ");
            int sel = Int32.Parse(Console.ReadLine());
            return sel;
        }

        static void clearScreen()
        {
            Console.Clear();
        }

        static void MainLoop()
        {
            bool isRun = true;
            while (isRun)
            {
                clearScreen();
                showMenu();
                int sel = getSelMenu();

                switch (sel)
                {
                    case DEV_EMPLOYEE:
                        DevEmployee();
                        break;
                    case SERVICE_EMPLOYEE:
                        ServiceEmployee();
                        break;
                    case MARKETING_EMPLOYEE:
                        MarketingEmployee();
                        break;
                    case INFO_EMPLOYEE:
                        InfoEmployee();
                        break;
                    case EMPLOYEE_SALARY:
                        YearEmployeeSalary();
                        break;
                    case EXIT:
                        isRun = false;
                        break;
                }
            }
        }

        static void DevEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("=== 개발직 정보 ===");
            Console.Write("소속: ");
            string department = Console.ReadLine();
            Console.Write("직급: ");
            string rank = Console.ReadLine();
            Console.Write("이름: ");
            string name = Console.ReadLine();

            DevEmployee devEmployee = new DevEmployee(rank, name, department);
            employeeList.Add(devEmployee);
        }

        static void ServiceEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("=== 서비스직 정보 ===");
            Console.Write("소속: ");
            string department = Console.ReadLine();
            Console.Write("직급: ");
            string rank = Console.ReadLine();
            Console.Write("이름: ");
            string name = Console.ReadLine();

            ServiceEmployee serviceEmployee = new ServiceEmployee(rank, name, department);

            employeeList.Add(serviceEmployee);
        }

        static void MarketingEmployee()
        {
            Console.WriteLine();
            Console.WriteLine("=== 영업직 정보 ===");
            Console.Write("소속: ");
            string department = Console.ReadLine();
            Console.Write("직급: ");
            string rank = Console.ReadLine();
            Console.Write("이름: ");
            string name = Console.ReadLine();

            MarketingEmployee marketingEmployee = new MarketingEmployee(rank, name, department);

            employeeList.Add(marketingEmployee);
        }
        
        static void InfoEmployee()
        {
            Console.WriteLine();
            int i = 0;
            foreach(Employee emp in employeeList)
            {
                Console.WriteLine("===== {0} =====", ++i);
                emp.showEmployeeInfo();
            }
            Console.ReadLine();
        }

        static void YearEmployeeSalary()
        {
            int i = 0;
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine();
                Console.WriteLine("===== {0} =====", ++i);
                Console.WriteLine("부서: " + emp.Department);
                Console.WriteLine("직급: " + emp.Rank);
                Console.WriteLine("이름: " + emp.Name);
                Console.WriteLine("연봉: {0}원", emp.yearSalary());
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            MainLoop();
        }
    }
}
