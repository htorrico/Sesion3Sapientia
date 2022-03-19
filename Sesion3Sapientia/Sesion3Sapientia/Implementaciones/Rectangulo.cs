using System;
using System.Collections.Generic;
using System.Text;

namespace Sesion3Sapientia
{
    class Rectangulo : IPoligono
    {
        public int Base { get; set; }
        public int Altura { get; set; }
        public int CalcularArea()
        {
            return Base * Altura;
        }

        public int CalcularPerimetro()
        {
            return 2 * (Base + Altura);
        }
    }
}
