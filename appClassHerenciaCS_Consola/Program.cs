using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto3D a;
            a = new Punto3D(100, 55.5, 0);
            Console.WriteLine(a.ToString());
            Console.ReadKey();
        }
    }
}
