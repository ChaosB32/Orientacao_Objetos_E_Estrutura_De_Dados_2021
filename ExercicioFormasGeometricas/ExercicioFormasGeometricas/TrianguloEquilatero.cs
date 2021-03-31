using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFormasGeometricas
{
    class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(int medida,string descricao) : base(medida,descricao)
        {
        }

        public override double CalcularArea()
        {
            return Medida * Medida * Math.Sqrt(3) / 4;
        }

        public override double CalcularPerimetro()
        {
            return 3 * Medida;
        }
    }
}
