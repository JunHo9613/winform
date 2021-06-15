using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Business App 설계
; MVC
1) 개념
    Model      : 데이터/데이터 입출력
    View       : 사용자와의 입출력(화면)
    Controller : 중개역할/비즈니스 로직

2) App 분류
  Model : Address, AddressFile
  View : AddressMenu 
  Controller : AddressManager
  프로그램 시작 : AddressClassMain
*/


namespace _61_AddressClass
{
    class AddressClassMain
    {
        static void Main(string[] args)
        {
            AddressMenu addressMenu = new AddressMenu();
            addressMenu.mainLoop();
        }
    }
}
