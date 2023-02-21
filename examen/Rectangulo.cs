using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examen
{
    public class Rectangulo : FiguraGeometrica
    {
        public new double Area(double Base, double Altura)
        {
            return Base * Altura;
        }

        public override string ToString()
        {
            FiguraGeometrica r = new FiguraGeometrica();
            return r.Nombre("Rectangulo");
        }
    }
}
