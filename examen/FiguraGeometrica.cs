using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace examen
{
    public class FiguraGeometrica : IPoligono
    {
        public double Area(double valor1, double valor2)
        {
            throw new NotImplementedException();
        }

        public string Nombre(string name)
        {
            return "El nombre de esta figura es:" + "\r\n" + name;
        }
    }
}
