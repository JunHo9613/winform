using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Data> mylist = new List<Data>();

            mylist.Add(new Data("aa", 1));
            mylist.Add(new Data("bb", 2));
            mylist.Add(new Data("cc", 3)); // element 추가하기 (맨뒤에 추가함.)

            display(mylist);

            Console.WriteLine("data count == {0}", mylist.Count); // 총 element 갯수 구하기
            Console.WriteLine("index 2 data == {0}", mylist[0]);  // 해당 index 의 element 추출하기

            Data newdata = new Data("dd", 4);
            mylist.Insert(1, newdata); // element 추가하기 ( 해당 index 에 삽입함.)
            mylist.Insert(1, newdata);

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine("index = {0}, name = {1}, age = {2}", i, mylist[i].Name, mylist[i].Age);
            }


            mylist.RemoveAt(3);  // 해당 index 의 element 삭제하기
            display(mylist);

            mylist.Remove(newdata);  // 해당 element를  List 에서 삭제하기 (첫번째 한개만 삭제)
            display(mylist);

            if (mylist.Contains(newdata)) // 해당 element를 가지고있는가? ; true/false
            {
                Console.WriteLine(" contains newdata....");
            }

            mylist.Clear();
            Console.WriteLine("남은 element 수 = {0}", mylist.Count);


            Console.ReadLine();

        }

        static void display(List<Data> data_coll)
        {
            foreach (Data data in data_coll)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine(" ------------------------------ ");
        }
    }


    class Data
    {
        private String name;
        private int age;

        public Data(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public String Name
        {
            get
            {
                return name;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
        }


        public override String ToString()
        {
            return String.Format("<name ={0}, age= {1}>", name, age);
        }
    }
}
