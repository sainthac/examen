using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace examen
{
    public class Triangulo : FiguraGeometrica
    {
        public new double Area(double Base, double Altura)
        {
            return 0.5 * (Base * Altura);
        }

        public override string ToString()
        {
            FiguraGeometrica t = new FiguraGeometrica();
            return t.Nombre("triangulo");
        }
    }
}
