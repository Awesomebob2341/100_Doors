using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_Doors
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] doors = new bool[100];

            for (int i = 0; i < doors.Length; i++)
            {
                doors[i] = false;
            }

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < doors.Length; j++)
                {
                    if ((j+1) % (i+1) == 0)
                    {
                        doors[j] = !doors[j];
                    }
                }
            }

            for (int i = 0; i < doors.Length; i++)
            {
                if (doors[i])
                    Console.WriteLine(String.Format("Door {0}: Open", i + 1));

                else
                    Console.WriteLine(String.Format("Door {0}: Closed", i + 1));
            }

            Console.ReadKey();
        }
    }
}
