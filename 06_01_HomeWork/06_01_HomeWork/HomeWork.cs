using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_01_HomeWork
{
    class Student
    {
        private string Name;
        private int Age, Korean, Math, English;

        public Student(string name, int age, int korean, int math, int english)
        {
            this.Name = name;
            this.Age = age;
            this.Korean = korean;
            this.Math = math;
            this.English = english;
        }

        public void basicinfo()
        {
            Console.WriteLine("기본정보 출력");
            Console.WriteLine("이름: " + this.Name);
            Console.WriteLine("나이: " + this.Age + "살");
        }

        public void allinfo()
        {
            Console.WriteLine("전체정보 출력");
            Console.WriteLine("이름: {0}, 나이: {1}살, 국어 점수: {2}점, 수학 점수: {3}점, 영어 점수: {4}점", this.Name, this.Age, this.Korean, this.Math, this.English);
        }

        public void totalscore()
        {
            int score = this.Korean + this.Math + this.English;
            Console.WriteLine("총점 : {0}점", score);
        }

        public void avg()
        {
            int avg = (this.Korean + this.Math + this.English) / 3;
            Console.WriteLine("평균 : {0}점", avg);
        }

    }

    class HomeWork
    {
        static void printInputNums()
        {
            while(true)
            {
                Console.Write("정수를 입력하시오 : ");
                int num = Int32.Parse(Console.ReadLine());

                if (num == 0)
                    break;
            }
        }

        static int[] getInputNums()
        {
            int[] num = new int[1000];

            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("정수를 입력하시오: ");
                num[i] = Int32.Parse(Console.ReadLine());
             
                if (num[i] == 0)
                    break;
            }
            return num;
        }

        static void Main(string[] args)
        {
            /* 사용자가 0을 입력하기 전까지 정수를 입력해서 출력하는
            메서드를 정의하고 사용하세요
            void printInputNums(); */

            /*printInputNums();*/

            /* 사용자가 0을 입력하기 전까지 정수를 입력해서 반환하는
            메서드를 정의하고 사용하세요
            int[] getInputNums(); */

            getInputNums();

            /* Student클래스를 정의하고 사용합니다
            이 클래스의 필드는 이름과 나이, 국어, 수학, 영어 점수를 갖습니다
            메서드는 필드를 초기화하기 위한 생성자
            기본정보 출력(이름과 나이)

            전체정보 출력(전체 필드)

            총점 출력

            평균 출력
            이렇게 구성합니다. */

            /*Student st = new Student("홍길동", 20, 80, 90, 60);

            st.basicinfo();
            Console.WriteLine();
            st.allinfo();
            Console.WriteLine();
            st.totalscore();
            Console.WriteLine();
            st.avg();*/
        }
    }
}
