using System;
using System.Collections.Generic;
//1.사용자가 0을 입력하기 전까지 정수를 입력해서 출력하는
//   메서드를 정의하고 사용하세요
//   void printInputNums();

//2.사용자가 0을 입력하기 전까지 정수를 입력해서 반환하는
//   메서드를 정의하고 사용하세요
//   int[] getInputNums();

//3.Student클래스를 정의하고 사용합니다
//   이 클래스의 필드는 이름과 나이, 국어, 수학, 영어
//   점수를 갖습니다
//   메서드는 필드를 초기화하기 위한 생성자
//            기본정보 출력(이름과 나이)
//			전체정보 출력(전체 필드)

//            총점 출력
//			평균 출력
//    이렇게 구성합니다.
namespace _005_Homework_0601
{
    class Homework
    {
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        private static void SelectQestion()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 0)
                    break;
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    case 3:
                        Q3();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }
        static void Q1()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. 사용자가 0을 입력하기 전까지 정수를 입력해서 출력하는 \n\t 메서드를 정의하고 사용하세요");
            Console.WriteLine("\n\t     void printInputNums();");
            Console.WriteLine("--------------------------------------------------------------------------------");
            printInputNums();
        }

        static void printInputNums()
        {
            List<int> nums = new List<int>();

            while (true)
            {
                Console.Write("숫자를 입력하세요 [종료 0] 입력:");
                int num = Int32.Parse(Console.ReadLine());
                nums.Add(num);

                if (num == 0)
                    break;
            }

            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine($"{i + 1}번째 입력하신 숫자는: {nums[i]}");
            }
        }

        static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t2. 사용자가 0을 입력하기 전까지 정수를 입력해서\n\t   반환하는 메서드를 정의하고 사용하세요");
            Console.WriteLine("\n\t     int[] getInputNums();");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int[] array = new int[5];
            array = getInputNums();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i + 1}번째 입력하신 숫자는 : {array[i]}");
            }
        }
        public static int[] getInputNums()
        {
            int[] nums = new int[5];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("숫자를 입력하세요 [종료 0] 입력:");
                nums[i] = Int32.Parse(Console.ReadLine());
                if (nums[i] == 0)
                    break;
            }
            return nums;
        }

        static void Q3()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3.Student클래스를 정의하고 사용합니다 \n\t이 클래스의 필드는 이름과 나이, 국어, 수학, 영어 점수를 갇고");
            Console.WriteLine("\t메소드는 필드를 초기화하기 위한 생성자 기본정보 출력(이름과 나이) ");
            Console.WriteLine("\n\t전체정보 출력(전체 필드) 총점 출력 평균 출력 구성 ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Student st = new Student("박재홍", 24, 90, 98, 100);
            Console.WriteLine("\n[기본정보]\n");
            st.PrintStudentInfo();
            Console.WriteLine("\n[전체정보]\n");
            st.PrintStudentAllInfo();
        }

        static void Main(string[] args)
        {
            SelectQestion();
        }
    }
    class Student
    {
        string name;
        int age;
        int English;
        int Korean;
        int math;

        public Student(string name, int age, int English, int Korean, int math)
        {
            this.name = name;
            this.age = age;
            this.English = English;
            this.Korean = Korean;
            this.math = math;
        }
        public void PrintStudentInfo()
        {
            Console.WriteLine($"이름:{name} 나이:{age}");
        }
        public void PrintStudentAllInfo()
        {
            Console.WriteLine($"이름:{name} 나이:{age}");
            Console.WriteLine($"영어점수:{English} 국어점수:{Korean} 수학점수:{math}");
            Console.WriteLine($"총점은:{English + Korean + math}");
            Console.WriteLine($"평균은:{(English + Korean + math) / 3}");

        }

    }
}
