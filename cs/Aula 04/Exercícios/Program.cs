using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercícios
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exercícios de algoritmos estruturados */

            //ExecutarExercicio1();
            //ExecutarExercicio2();
            //ExecutarExercicio3();
            //ExecutarExercicio4();
            //ExecutarExercicio5();
            //ExecutarExercicio6();
            //ExecutarExercicio7();
            //ExecutarExercicio8();
            ExecutarExercicio9();


            Console.ReadLine(); //faz uma pausa.
        }

        /**
         * 9. Faça um algoritmo que leia 
         * "N" números e mostre positivo, negativo 
         * ou zero para cada número.
         **/
        private static void ExecutarExercicio9()
        {
            bool deveContinuarLeitura = true;

            while (deveContinuarLeitura)
            {
                Console.WriteLine("Digite um número ou 'N' para sair:");
                string s = Console.ReadLine();

                if (s == "N")
                {
                    deveContinuarLeitura = false;
                }
                else
                {
                    int numero = int.Parse(s);

                    if (numero > 0)
                    {
                        Console.WriteLine("O número é positivo.");
                    }
                    else if (numero < 0)
                    {
                        Console.WriteLine("O número é negativo.");
                    }
                    else
                    {
                        Console.WriteLine("O número é zero.");
                    }
                }

            }
        }


        /**
         * 8. Faça um algoritmo que leia um número 
         * e mostre uma mensagem caso este número 
         * seja maior que 50, menor que 10 ou igual a 20.
         **/
        static void ExecutarExercicio8()
        {
            Console.WriteLine("Informe um número");
            string s = Console.ReadLine();

            int numero = int.Parse(s);

            if (numero > 50)
            {
                Console.WriteLine("O número {0} é maior do que 50.", numero);
            }
            else if (numero < 10)
            {
                Console.WriteLine("O número {0} é menor do que 10.", numero);
            }
            else if (numero == 20)
            {
                Console.WriteLine("O número {0} é igual a 20.", numero);
            }
            else
            {
                Console.WriteLine("O número não está na faixa desejada.");
            }


        }



        /**
         * 7. Faça um algoritmo que leia um 
         * número e diga se este número está no 
         * intervalo entre 100 e 200.
         **/
        private static void ExecutarExercicio7()
        {
            Console.WriteLine("Informe o número:");
            string s1 = Console.ReadLine();

            int numero = int.Parse(s1);

            if (numero >= 100 && numero <= 200)
            {
                Console.WriteLine("O numero {0} está no intervalo de 100 a 200.", numero);
            }
            else
            {
                Console.WriteLine("O numero {0} está fora do intervalo de 100 a 200.", numero);
            }
        }

        /**
         * 6. Leia uma temperatura em graus Celsius e 
         * apresente-a convertida em graus Fahrenheit. 
         * A fórmula de conversão é:
         * F=(9*C+160) / 5, 
         * sendo F a temperatura em Fahrenheit e 
         * C a temperatura em Celsius.
         **/
        private static void ExecutarExercicio6()
        {
            Console.WriteLine("Informe a temperatura em graus Celsius:");
            string sTemp = Console.ReadLine();
            double grausCelsius = double.Parse(sTemp);
            double grausFahrenheit = (9 * grausCelsius + 160) / 5;
            Console.WriteLine("A temperatura em Fahrenheit é {0}.", grausFahrenheit);
        }

        /**
         * 5. Leia os valores para as variáveis A e B 
         * e efetue as trocas dos valores de forma que 
         * a variável A passe a possuir o valor da variável B 
         * e a variável B passe a possuir o valor da 
         * variável A. Apresentar os valores trocados.
         **/
        private static void ExecutarExercicio5()
        {
            Console.WriteLine("Informe o valor da primeira variável:");
            string a = Console.ReadLine();
            Console.WriteLine("Informe o valor da segunda variável:");
            string b = Console.ReadLine();

            string temp = a;
            a = b;
            b = temp;

            Console.WriteLine("A variável A valia {0} e agora vale {1}.", b, a);
            Console.WriteLine("A variável B valia {0} e agora vale {1}.", a, b);
        }

        /**
         * 4. Faça um algoritmo que leia dois números 
         * e ao final mostre a soma, subtração, multiplicação 
         * e a divisão dos números lidos.
         * */
        private static void ExecutarExercicio4()
        {
            Console.WriteLine("Informe o primeiro número:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo número:");
            string s2 = Console.ReadLine();

            double valor1 = double.Parse(s1);
            double valor2 = double.Parse(s2);

            Console.Clear();

            var resultado = valor1 + valor2;
            Console.WriteLine("Soma: {0} + {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 - valor2;
            Console.WriteLine("Subtração: {0} - {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 * valor2;
            Console.WriteLine("Multiplicação: {0} * {1} = {2}", valor1, valor2, resultado);

            resultado = valor1 / valor2;
            Console.WriteLine("Divisão: {0} / {1} = {2}", valor1, valor2, resultado);
            
        }

        /**
         * 3. Escreva um algoritmo que leia
         * dois valores inteiros distintos e 
         * informe qual deles é o maior.
         **/
        private static void ExecutarExercicio3()
        {
            Console.WriteLine("Informe o primeiro número:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Informe o segundo número:");
            string s2 = Console.ReadLine();

            double valor1 = double.Parse(s1);
            double valor2 = double.Parse(s2);

            Console.Clear();

            if (valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor {0} é maior do que {1}!", valor1, valor2);
            }
            else
            {
                Console.WriteLine("O segundo valor {0} é maior do que {1}!", valor2, valor1);
            }
        }

        /**
         * 2. Faça um algoritmo que  
         * declarado dois números, exiba 
         * o resultado da sua soma destes
         * dois números.
         **/
        private static void ExecutarExercicio2()
        {
            int numero1 = 10;
            int numero2 = 15;
            int resultado = numero1 + numero2;

            Console.WriteLine("A soma dos números é: {0}", resultado);
        }


        /**
         * 1. Faça um algoritmo que declarado 
         * um número, mostre uma mensagem caso 
         * este número seja maior que 10 e outra
         * case seja menor ou igual a 10.
         **/
        private static void ExecutarExercicio1()
        {
            int numero = 15;

            if (numero > 10)
            {
                Console.WriteLine("O número {0} é maior do que 10!", numero);
            }
            else
            {
                Console.WriteLine("O número {0} é menor ou igual a 10!", numero);
            }
        }
    }
}
