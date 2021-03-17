using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImc_Lab01
{
    class Usuario
    {
        public string nome;
        public int idade;
        public float peso;
        public float altura;

        public Usuario(string nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        private float CalcularImc()
        {
            return this.peso / (this.altura * this.altura);
        }
        
        public string InformarSituacaoImc()
        {
            float imc = CalcularImc();
            string situacaoImc = "Erro de identificação";

            if(imc>=18.5f && imc <= 24.9f)
                situacaoImc = "Parabéns — você está em seu peso normal!";
            if (imc >= 25.0f && imc <= 29.9f)
                situacaoImc = "Você está acima de seu peso (sobrepeso).";
            if (imc >= 30.0f && imc <= 34.9f)
                situacaoImc = "Obesidade grau I.";
            if (imc >= 35.0f && imc <= 39.9f)
                situacaoImc = "Obesidade grau II.";
            if (imc >= 40.0f)
                situacaoImc = "Obesidade graus III e IV.";
            return situacaoImc;
        }
        
        public float InformarMetaPeso()
        {
            float imcIdeal = 24.9f;
            float pesoIdeal = imcIdeal * (this.altura) * (this.altura);
            return pesoIdeal;
        }
    }
}
