using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2021_06_03.추상_메서드
{
    class SaveLoad
    {
        public void SaveFile(ArrayList arrList)
        {
            StreamWriter save = new StreamWriter("Worker.txt");
            for(int i = 0; i < arrList.Count; i++)
            {
                Worker work = (Worker)arrList[i];
                if(work is Regular)
                {
                    save.WriteLine("Regular");
                    save.WriteLine(((Regular)work).emNum);
                    save.WriteLine(((Regular)work).emName);
                    save.WriteLine(((Regular)work).Pay);
                    save.WriteLine(((Regular)work).bonus);
                    save.WriteLine();
                }
                else if(work is Temporary)
                {
                    save.WriteLine("Temporary");
                    save.WriteLine(((Temporary)work).emNum);
                    save.WriteLine(((Temporary)work).emName);
                    save.WriteLine(((Temporary)work).Pay);
                    save.WriteLine(((Temporary)work).hireYear);
                    save.WriteLine();
                }

                else if (work is Contract_Worker)
                {
                    save.WriteLine("Contract_Worker");
                    save.WriteLine(((Contract_Worker)work).emNum);
                    save.WriteLine(((Contract_Worker)work).emName);
                    save.WriteLine(((Contract_Worker)work).Pay);
                    save.WriteLine(((Contract_Worker)work).workDay);
                    save.WriteLine();
                }
            }
            save.Close();
        }
    }
}
