using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Ja sam kalkulator sume reda 1/3+1/9+1/27... Unesi broj clanova reda: \n");
            int x = Convert.ToInt32(Console.ReadLine());
        
            double y=1.0/3;
            double suma = 0;
            for (int i = 0; i <= x; i++)
            {
                suma += y;
                y = y / 3;
         
            }
            Console.WriteLine("Suma je: " + suma);
            Console.ReadKey();
        }
    }
}
