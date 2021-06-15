using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TeamProject;

namespace Project1
{
    class title
    {
        public static void Main()
        {
            TeamProjectManager teamProject = new TeamProjectManager();
            
            Random rand = new Random();
            ConsoleColor[] Color = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.DarkGray, ConsoleColor.Blue }; //배경색과 폰트색을 랜덤하게 바꿀 색상들
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey();
                    if (cki.KeyChar == '0')
                        break;
                }

                Console.Clear();

                Console.ForegroundColor = Color[rand.Next(6)];
                Console.Title = "자 드가자";

                Console.WriteLine("\n\n\n\n");
                Console.WriteLine("\t" + "      ####     #    ###  #     #        ####  ##   #  ####");
                Console.WriteLine("\t" + "      #   #   # #   #    #   #          #     # #  #  #   #");
                Console.WriteLine("\t" + "      ####   #####  #    # #    ======  ####  #  # #  #    #");
                Console.WriteLine("\t" + "      #   #  #   #  #    #   #          #     #   ##  #   #");
                Console.WriteLine("\t" + "      #####  #   #  ###  #     #        ####  #    #  #### ");
                Thread.Sleep(10); //0.01초대기
            }

            Console.Clear();
            teamProject.MenuLoop();

        }
    }
}

        




