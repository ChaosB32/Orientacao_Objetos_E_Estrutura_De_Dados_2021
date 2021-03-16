using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    class Usuario
    {
        public string nome;
        public int idade;
        public float altura;
        public float peso;
        public float imc;
        public float meta;

        public Usuario(float _altura, float _peso)
        {
            this.altura = _altura;
            this.peso = _peso;
        }
        public Usuario()
        {

        }
        public void CalcularImc()
        {
            imc = peso / (altura * altura);
            meta = 24.9f * (altura * altura);

            if(imc >= 18.5f && imc <= 24.9f)
            {
                Console.WriteLine(" Usuário: {0}\n Idade: {1}\n Altura: {2} M\n Peso: {3} Kg\n IMC: {4}\n Situação: {5}\n Meta: {6} Kg ",nome,idade,altura,peso,imc, "Parabéns — você está em seu peso normal! ",meta);
                Console.ReadLine();
            }
            if(imc >= 25.0f && imc <= 29.9f)
            {
                Console.WriteLine(" Usuário: {0}\n Idade: {1}\n Altura: {2} M\n Peso: {3} Kg\n IMC: {4}\n Situação: {5}\n Meta: {6} Kg ",nome,idade,altura,peso,imc, "Você está acima de seu peso (sobrepeso). ",meta);
                Console.ReadLine();
            }
            if (imc >= 30f && imc <= 34.9f)
            {
                Console.WriteLine(" Usuário: {0}\n Idade: {1}\n Altura: {2} M\n Peso: {3} Kg\n IMC: {4}\n Situação: {5}\n Meta: {6} Kg ", nome, idade, altura, peso, imc, "Obesidade grau I. ",meta);
                Console.ReadLine();
            }
            if (imc >= 35f && imc <= 39.9f)
            {
                Console.WriteLine(" Usuário: {0}\n Idade: {1}\n Altura: {2} M\n Peso: {3} Kg\n IMC: {4}\n Situação: {5}\n Meta: {6} Kg ", nome, idade, altura, peso, imc, "Obesidade grau II. ",meta);
                Console.ReadLine();
            }
            if (imc >= 40f)
            {
                Console.WriteLine(" Usuário: {0}\n Idade: {1}\n Altura: {2} M\n Peso: {3} Kg\n IMC: {4}\n Situação: {5}\n Meta: {6} Kg ", nome, idade, altura, peso, imc, "Obesidade graus III e IV. ",meta);
                Console.ReadLine();
            }

        }
    }
}
