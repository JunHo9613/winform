using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework0601
{
    class Student
    {
        //1-3. Student클래스를 정의하고 사용합니다
        //이 클래스의 필드는 이름과 나이, 국어, 수학, 영어
        //점수를 갖습니다
        //메서드는 필드를 초기화하기 위한 생성자
        //기본정보 출력(이름과 나이)

        //전체정보 출력(전체 필드)

        //총점 출력

        //평균 출력
        //이렇게 구성합니다.

         private string name;
         private int age;
         private int koresc;
         private int mathsc;
         private int engsc;

         public Student(string name, int age, int koresc, int mathsc, int engsc)
         {
             this.name = name;
             this.age = age;
             this.koresc = koresc;
             this.mathsc = mathsc;
             this.engsc = engsc;
         }

         public void nameage()
         {
             Console.WriteLine("기본정보");
             Console.WriteLine("이름 : " + name);
             Console.WriteLine("나이 : " + age);
         }

         public void allInfo()
         {
             Console.WriteLine("전체정보");
             Console.WriteLine("이름 : " + name);
             Console.WriteLine("나이 : " + age);
             Console.WriteLine("국어 점수: " + koresc);
             Console.WriteLine("수학 점수: " + mathsc);
             Console.WriteLine("영어 점수: " + engsc);
         }

         public void allscore()
         {
             int sumsc = koresc + mathsc + engsc;
             Console.WriteLine("총점은 : " + sumsc);
         }

         public void avgscore()
         {
             int avgsc = koresc + mathsc + engsc / 3;
             Console.WriteLine("평균은 : " + avgsc);
         }


    }
    class printinput
    {
        //1. 사용자가 0을 입력하기 전까지
        //정수를 입력해서 출력하는
        //메서드를 정의하고 사용하세요
        /*public void printInputNums()
        {
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    Console.WriteLine("0이 출력되었습니다 빠져나갑니다.");
                    break;
                }

            }
        }*/

        //2. 사용자가 0을 입력하기 전까지
        //정수를 입력해서 반환하는
        //메서드를 정의하고 사용하세요
        //int[] getInputNums();
        /*public int[] getInputNums()
        {
            int[] numarr = new int[50];
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < numarr.Length; i++)
            {
                numarr[i] = num;
                return numarr;
            }

        }*/

        
    }
    class HomeWork1
    {
        static void Main(string[] args)
        {
            //printinput pr = new printinput();
            //pr.printInputNums();
            
            Student st = new Student("홍길동", 25, 90, 100, 80);
            st.nameage();
            st.allInfo();
            st.allscore();
            st.avgscore();
        }
    }
}

