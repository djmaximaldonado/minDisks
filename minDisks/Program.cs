using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minDisks
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir) {

            Console.WriteLine("****MinDisks by Maximiliano Maldonado***");
            Console.WriteLine("---Menu---");
            Console.WriteLine("1- Insert information");
            Console.WriteLine("2- Run tests");
            Console.WriteLine("3- Exit");

            int option = ReadInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.WriteLine("Insert amount of disks:");
                    int amount = ReadInt32(Console.ReadLine());

                    //used
                    Console.WriteLine("Insert USED disk space (Separated by enter)");
                    int[] used = new int[amount];
                    for (int i = 0; i < used.Length; i++)
                    {
                        used[i] = ReadInt32(Console.ReadLine());
                    }

                    //total
                    Console.WriteLine("Insert TOTAL disks space (Separated by enter)");
                    int[] total = new int[amount];
                    for (int i = 0; i < total.Length; i++)
                    {
                        total[i] = ReadInt32(Console.ReadLine());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Used: [{0}]", string.Join(", ", used));
                    Console.WriteLine("Total: [{0}]", string.Join(", ", total));

                    int result = minDrives(used, total);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("");

                }
                else if (option == 2)
                {
                    Console.WriteLine("***Test 0***");   
                    int[] used = new int[] { 300, 525, 110 };
                    int[] total = new int[] { 350, 600, 115 };
                    Console.WriteLine("Used: [{0}]", string.Join(", ", used));
                    Console.WriteLine("Total: [{0}]", string.Join(", ", total));
                    int result = minDrives(used, total);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("");

                    Console.WriteLine("***Test 1***");
                    used = new int[] { 1, 200, 200, 199, 200, 200 };
                    total = new int[] { 1000, 200, 200, 200, 200, 200 };
                    Console.WriteLine("Used: [{0}]", string.Join(", ", used));
                    Console.WriteLine("Total: [{0}]", string.Join(", ", total));
                    result = minDrives(used, total);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("");

                    Console.WriteLine("***Test 2***");
                    used = new int[] { 750, 800, 850, 900, 950 };
                    total = new int[] { 800, 850, 900, 950, 1000 };
                    Console.WriteLine("Used: [{0}]", string.Join(", ", used));
                    Console.WriteLine("Total: [{0}]", string.Join(", ", total));
                    result = minDrives(used, total);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("");

                    Console.WriteLine("***Test 3***");
                    used = new int[] {49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49,49};
                    total = new int[] {50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50,50};
                    Console.WriteLine("Used: [{0}]", string.Join(", ", used));
                    Console.WriteLine("Total: [{0}]", string.Join(", ", total));
                    result = minDrives(used, total);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("");

                    Console.WriteLine("***Test 4***");
                    used = new int[] { 331, 242, 384, 366, 428, 114, 145, 89, 381, 170, 329, 190, 482, 246, 2, 38, 220, 290, 402, 385 };
                    total = new int[] { 992,509,997,946,976,873,771,565,693,714,755,878,897,789,969,727,765,521,961,906 };
                    Console.WriteLine("Used: [{0}]", string.Join(", ", used));
                    Console.WriteLine("Total: [{0}]", string.Join(", ", total));
                    result = minDrives(used, total);
                    Console.WriteLine("Result: " + result);
                    Console.WriteLine("");
                }
                else if (option == 3)
                    salir = true;

            }

           

    }

        //algorithm
        public static int minDrives(int[] used , int[] total )
        {
            int usedSum = 0;
            int result = 0;
            foreach (int element in used)
                usedSum += element;

            Array.Sort(total);
            Array.Reverse(total);

            int i = 0;
            while ( usedSum > 0 ) 
            {
                usedSum -= total[i];
                result++;
                i++;
            }

            return result;
        }


        // aux function to read an int from console
        public static int ReadInt32(string value)
        {
            int val = -1;
            if (!int.TryParse(value, out val))
                return -1;
            return val;
        }
    }
}
