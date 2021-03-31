using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioFormasGeometricas
{
    abstract class FormaGeometrica
    {
        protected FormaGeometrica(int medida,string descricao)
        {
            Medida = medida;
            Descricao = descricao;
        }

        public int Medida { get; set; }
        public string Descricao { get; set; }

        public abstract double CalcularPerimetro();

        public abstract double CalcularArea();
    }
}
