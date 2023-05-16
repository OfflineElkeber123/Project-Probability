using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Probaility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_ Enter N _");
            int N = int.Parse(Console.ReadLine());
            int[] project = new int[N];
            Console.WriteLine("_ Enter Numbers _");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(" Number " + (i + 1) + " = ");
                project[i] = int.Parse(Console.ReadLine());
            }
                Array.Sort(project);
                int x ;
                int z ;
                int Median; 
                if (N % 2 == 0)
                {
                    x = N / 2;
                    z = (N / 2) - 1;
                    Median = (project[x] + project[z] ) / 2 ;
                    Console.WriteLine(" The Median = " + Median);
                } 
            else 
                {
                    int w = (N-1) / 2 ;
                    Median = project[w];
                    Console.WriteLine(" The Median = "+ Median);
                }

                int Range ; 
                Range = (N - 1) - 0;
                Console.WriteLine(" The Range = " + Range);

                int Q1;
                if (N % 2 == 0)
                {
                    Q1 = project[(N - 1) / 4];
                    Console.WriteLine(" Q1  = " + Q1);
                }
                else
                {
                    Q1 = project[(N - 2) / 4];
                    Console.WriteLine(" Q1  = " + Q1);
                }

                int Q3;
                if (N % 2 == 0)
                {
                    Q3 = project[(N + 1) * 3 / 4];
                    Console.WriteLine(" Q3  = " + Q3);
                }
                else
                {
                    Q3 = project[N * 3 / 4 ];
                    Console.WriteLine(" Q3  =" + Q3);
                } 
                
                var groups = project.GroupBy(y => y);
                var maxaccount = groups.Max(m => m.Count());
                var mode = groups.First(m => m.Count() == maxaccount).Key;
                Console.WriteLine(" The mode = " + mode);

                int P90 ;
                int count = N ;
                int index = (int)Math.Round(count * 0.9) - 1;
                 P90 = project[index];
                Console.WriteLine("p90 value = " + P90);

                int interquartile ;
                 interquartile = Q3 - Q1;
                Console.WriteLine(" The interquartile = " + interquartile);
                
                double uproutiler = Q3 + (1.5 * interquartile);
                double lowroutiler = Q1 - (1.5 * interquartile);
                Console.WriteLine(" The UPROUTILER is = " + uproutiler);
                Console.WriteLine(" The LOWROUTILER is = " + lowroutiler);
                Console.WriteLine(" Enter variable outiler = ");
                int Determine = int.Parse(Console.ReadLine());
                if (Determine < uproutiler && Determine > lowroutiler)
                {
                    Console.WriteLine("Value is Existed and = " + Determine);
                }
                else
                {
                    Console.WriteLine("_ Value is Not Existed _");
                }

        }


    }
}
