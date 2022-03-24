using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace SistemaACME
{
    class Usuario
    {
        public String nome;
        public int idade;
        public float altura;
        public float peso;


        public Usuario(string nome, int idade, float altura, float peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }

        public float CalcularImc()
        {
            return peso / (altura*altura);
        }

        
        public float CalcularMeta()
        {
           
            float peso = imc/(altura * altura);
            return peso;
        }
        

        public void DescricaoIMC()
        {
            //Calcular IMC do Usuário
            float imc = CalcularImc();

            float meta = CalcularMeta();
           

            Console.WriteLine($"Seu IMC atual é {imc}.");

            //Condição
            if (imc >= 18.2 & imc <= 24.9)
            {
                Console.WriteLine("Parabens você está com seu peso normal");
            }
            if (imc >= 25.0 & imc <= 29.9)
            {
                Console.WriteLine("Você está acima do seu peso.");
                Console.WriteLine($"META: Você precisa emagrecer{meta}");
            }
            if (imc >= 30.0 & imc <= 34.9)
            {
                Console.WriteLine("Obesidade Grau 1");
                Console.WriteLine($"META: Você precisa emagrecer{meta}");
            }
            if (imc >= 35.0 & imc <= 40)
            {
                Console.WriteLine("Obesidade Grau 2");
                Console.WriteLine($"META: Você precisa emagrecer{meta}");
            }
            if (imc >= 40.0)
            {
                Console.WriteLine("Obesidade Grau 3 e 4.");
                Console.WriteLine($"META: Você precisa emagrecer{meta}");
            }
        }
    }
}
