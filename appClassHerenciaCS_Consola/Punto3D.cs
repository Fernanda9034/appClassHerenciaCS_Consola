using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appClassHerenciaCS_Consola
{
    class Punto3D : Punto2D
    {
        protected double c;

        public double C
        {
            get { return c; }
            set { c = value; }
        }
        private double distance;

        public double Distance
        {
            get { return distance; }
            set { distance = value; }
        }
        public Punto3D() : base()
        {
            c = 0;
        }
        public Punto3D(double x, double y, double c) : base (x, y)
        {
            this.c = c;
            distance = Math.Sqrt(Math.Pow(x - y, 2));
        }
        public override string ToString()
        {
            return base.ToString() + " C= " + distance + "  Distancia de X a Y = " + distance;
        }
    }
}
