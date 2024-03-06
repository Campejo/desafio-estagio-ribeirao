using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace desafio_estagio_ribeirao.Models
{
    public class Desafios
    {
        public void Desafio01()
        {
            int indice = 13, soma = 0, k = 0;

            while (k < indice)
            {
                k += 1;
                soma += k;
            }

            Console.WriteLine(soma);
        }


        public void Desafio02()
        {
            Console.WriteLine("Digite um número inteiro maior que 0");
            int x = Convert.ToInt32(Console.ReadLine());

            if(sequenciaDeFibonacci(x))
            {
                Console.WriteLine($"O número {x} pertence a sequência de Fibonacci");
            }
            else
            {
                Console.WriteLine($"O número {x} não pertence a sequência de Fibonacci");
            }

            bool sequenciaDeFibonacci(int num)
            {
                int a = 0;
                int b = 1;

                while(b <= num)
                {
                    if(b == num)
                    {
                        return true;
                    }
                    
                    int temporario = a + b;
                    a = b;
                    b = temporario;
                }

                return false;
            }          
        }


        public void Desafio03()
        {
            Console.WriteLine("a) 9");
            Console.WriteLine("b) 128");
            Console.WriteLine("c) 49");
            Console.WriteLine("d) 100");
            Console.WriteLine("e) 13");
            Console.WriteLine("f) 20");
        }

        public void Desafio04()
        {
            Console.WriteLine("Eu acenderia uma das lâmpadas por um certo tempo,");
            Console.WriteLine("depois desse tempo eu apagaria essa lâmpada e acenderia uma segunda,");
            Console.WriteLine("após isso eu iria até uma das salas das lâmpadas e observaria o seguinte:");
            Console.WriteLine("");
            Console.WriteLine("1° se a lâmpada estiver acesa eu já sei que foi o interruptor que deixei ligado;");
            Console.WriteLine("");
            Console.WriteLine("2° caso a lâmpada estivesse apagada eu tocaria nela para sentir se estava quente ou fria, caso estivesse");
            Console.WriteLine("fria eu saberia que foi o interruptor que não liguei em momento algum, e caso estivesse quente eu saberia que era o primeiro");
            Console.WriteLine("interruptor que liguei.");
        }

        public void Desafio05()
        {
            Console.WriteLine("Escreva uma palavra");
            string receberString = Console.ReadLine();

            string stringInvertida = InverterString(receberString);

            string InverterString(string palavra)
            {
                string stringInvertida = "";

                for(int indice = palavra.Length - 1; indice >= 0; indice --)
                {
                    stringInvertida += palavra[indice];
                }
                
                return stringInvertida;
            }

            Console.WriteLine(stringInvertida);
        }
    }
}