using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFormasGeometricas
{
    class Hexagono : FormaGeometrica
    {
        public Hexagono(int medida,string descricao) : base(medida,descricao)
        {

        }
        public override double CalcularArea()
        {
            return 3*(Medida * Medida) * Math.Sqrt(3) / 2;
        }

        public override double CalcularPerimetro()
        {
            return 6 * Medida;
        }
    }
}
