using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion3Sapientia
{
    class Cuadrado : IPoligono
    {
        public int Lado { get; set; }

        public int CalcularArea()
        {
            return Lado * Lado;
        }

        public int CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}
