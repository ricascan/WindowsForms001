using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsolaXML
{
    class Program2
    {
        static void Main(string[] args)
        {
            StringBuilder cadena = new StringBuilder("hola");
            for (int i = 0; i < 400000; i++)
            {
                cadena.Append(" hola " + i + " adios " + i + " jaja ");
            }

            Console.WriteLine(cadena);
            Console.ReadLine();
        }

        
    }
}
