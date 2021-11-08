using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DTextMap
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("TextMap");
            Console.ReadKey(true);
        }

        static void DisplayMap()
        {
            string[,] map1 = new string[10, 10];

            for (int x = 0; x <= 10; x++)
            {
                for (int y = 0; y <= 10; y++)
                {
                    Console.Write(map1[x, y]);
                    char[,] map = new char[10, 10];




                }
            }
            

        }
        static void DisplayMap(int scale)
        {

        }


        
        
            
    }

}
