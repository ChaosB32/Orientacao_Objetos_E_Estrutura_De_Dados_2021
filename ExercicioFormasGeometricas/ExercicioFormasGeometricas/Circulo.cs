using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFormasGeometricas
{
    class Circulo : FormaGeometrica
    {
        public Circulo(int medida,string descricao) : base(medida,descricao)
        {
        }

        public override double CalcularArea()
        {
            return Medida * Medida * Math.PI;
        }

        public override double CalcularPerimetro()
        {
            return 2*Medida*Math.PI;
        }
    }
}
