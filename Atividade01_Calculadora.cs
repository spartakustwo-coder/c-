using System;

internal class Calculadora
{
    internal class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Escolha a sua operação:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");

            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            int result = 0;

            switch (operacao)
            {
                case 1:
                    result = Adicao(num1, num2);
                    break;
                case 2:
                    result = Subtracao(num1, num2);
                    break;
                case 3:
                    result = Multiplicacao(num1, num2);
                    break;
                case 4:
                    result = Divisao(num1, num2);
                    break;
                default:
                    Console.WriteLine("Número inválido, digite outro número.");
                    return;
            }

            Console.WriteLine("Resultado: " + result);
        }

        public static int Adicao(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicacao(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divisao(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
