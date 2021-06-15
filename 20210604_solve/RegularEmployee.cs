using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210604_solve
{
    class RegularEmployee : Employee
    {
        public RegularEmployee(string companyNum, string name, int pay, int bonus)
            : base(companyNum, name, pay) 
            // base 는 자식 객체가 생성되기 전에 부모객체가 먼저 생성된다.
            // 즉, 자식 생성자가 호출되기 전에 부모 생성자가 먼저 호출된다.
            // 그러므로 부모 생성자의 매개변수를 자식 생성자에서 전달해줘야 한다.
            // 부모생성자는 base는 부모 생성자를 의미한다.
        {
            this.Bouns = bonus;
        }

        public int Bouns { get; set; }

        public virtual void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("보너스 : " + this.Bouns);
            Console.WriteLine("월급:" + getMonthDay());
        }

        
        public override double getMonthDay()
        {
            return this.Pay / 12 + this.Bouns / 12;
        }
    }
}
