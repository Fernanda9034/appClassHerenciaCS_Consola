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
            //Punto2D a;
            //a = new Punto2D(34, 98);
            //Console.WriteLine(a.ToString());

            //Punto2D b;
            //b = new Punto2D(105, 98);
            //Console.WriteLine(b.ToString());

            //Punto3D z;
            //z = new Punto3D(256, 89, 100);
            //Console.WriteLine(z.ToString());

            //double d = a.Distancia(z);
            //Console.WriteLine("Distancia= " + d);

            //Console.ReadKey();

            Punto3D a;
            a = new Punto3D(78, 29, 31.2);
            Console.WriteLine(a.ToString());

            Punto3D b;
            b = new Punto3D(93,38.97,74);
            Console.WriteLine(b.ToString());

            double d = a.Distancia(b);
            Console.WriteLine("Distancia= " +d);

            Console.ReadKey();
        }
    }
}
