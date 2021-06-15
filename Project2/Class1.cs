using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class Document
    {
        public virtual void schedule() { Console.WriteLine(" "); }
    }
    class Vacation : Document
    {
        public override void schedule() { Console.WriteLine("방학"); }
    }
    class Businesstrip : Document
    {
        public override void schedule() { Console.WriteLine("회의"); }
    }
    class Meeting : Document
    {
        public override void schedule() { Console.WriteLine("출장"); }
    }

    class PolymorphismEx
    {
        static void attackCount(Document starUnit, int cnt)
        {
            Document[] starArr = new Document[3];
            starArr[0] = new Document();
            starArr[1] = new Vacation();
            starArr[2] = new Businesstrip();
            attackCount(starArr[0], 3);
            attackCount(starArr[1], 5);
            attackCount(starArr[2], 7);

        }                                        
    }
}
