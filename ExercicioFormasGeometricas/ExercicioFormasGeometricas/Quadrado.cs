using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFormasGeometricas
{
    class Quadrado : FormaGeometrica
    {
        public Quadrado(int medida,string descricao) : base(medida,descricao)
        {
        }

        public override double CalcularArea()
        {
            return Medida*Medida;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Medida;
        }
    }
}
