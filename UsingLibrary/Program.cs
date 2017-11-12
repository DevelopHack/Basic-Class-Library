using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UsingLibrary
{
    using LT.LibraryTriangle;
    class Program
    {       
        static void Main(string[] args)
        {            
            Console.WriteLine("Area is: {0:N2}",Triangle.AreaBaseHeight(5,3));
            Console.WriteLine("Area is: {0:N2}",Triangle.AreaSideLengths(3,4,5));
            Console.WriteLine("Area is: {0:N2}",Triangle.AreaOneSide(6));
            Console.WriteLine("Area is: {0:N2}",Triangle.AreaTrigonometry(150,231,123));
            Console.ReadKey();
        }
    }
}
