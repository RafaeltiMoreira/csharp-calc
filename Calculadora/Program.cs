using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;

namespace Calculadora {
    class Program {
        enum Menu { Soma = 1, Subtracao = 2, Divisao = 3, Multiplicacao = 4, Potencia = 5, Raiz = 6, Sair = 7 };
        static void Main(string[] args) {
            
            bool escolheuSair = false;
            // Enquanto o usuário NÃO(!) escolher SAIR exiba o menu
            while (!escolheuSair) {
                Console.WriteLine("Seja bem vindos (as) ao CALC, selecione uma das opções:");
                Console.WriteLine();
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Potência");
                Console.WriteLine("6 - Raiz");
                Console.WriteLine("7 - Sair");
                Console.WriteLine();

            /* 
            * string opcaoTXT = Console.ReadLine();
            * int opcaoInt = int.Parse(opcaoTXT);
            * Menu opcao = (Menu)opcaoInt;
            */

            Menu opcao = (Menu)int.Parse(Console.ReadLine());

            switch (opcao) {
                case Menu.Soma:
                    Soma();
                    break;
                case Menu.Subtracao:
                    Subtracao();
                    break;
                case Menu.Divisao:
                    Divisao();
                    break;
                case Menu.Multiplicacao:
                    Multiplicacao();
                    break;
                case Menu.Potencia:
                    Potencia();
                    break;
                case Menu.Raiz:
                    Raiz();
                    break;
                case Menu.Sair:
                    escolheuSair = true;
                    break;
            }

            Console.Clear();
        }
    }

    static void Soma() {
        Console.WriteLine("Soma de dois números:");
        Console.WriteLine("Digite o primeiro número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int b = int.Parse(Console.ReadLine());
        int resultado = a + b;
        Console.WriteLine($"O resultado é: {resultado}");
        Console.WriteLine("Aperte ENTER para voltar para o Menu");
        Console.ReadLine();
    }

    static void Subtracao() {
        Console.WriteLine("Subtração de dois números:");
        Console.WriteLine("Digite o primeiro número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int b = int.Parse(Console.ReadLine());
        int resultado = a - b;
        Console.WriteLine($"O resultado é: {resultado}");
        Console.WriteLine("Aperte ENTER para voltar para o Menu");
        Console.ReadLine();
    }

    static void Divisao() {
        Console.WriteLine("Divisão de dois números:");
        Console.WriteLine("Digite o primeiro número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int b = int.Parse(Console.ReadLine());
        float resultado = (float)a / (float)b;
        Console.WriteLine($"O resultado é: {resultado}");
        Console.WriteLine("Aperte ENTER para voltar para o Menu");
        Console.ReadLine();
    }

    static void Multiplicacao() {
        Console.WriteLine("Multiplicação de dois números:");
        Console.WriteLine("Digite o primeiro número:");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número:");
        int b = int.Parse(Console.ReadLine());
        int resultado = a * b;
        Console.WriteLine($"O resultado é: {resultado}");
        Console.WriteLine("Aperte ENTER para voltar para o Menu");
        Console.ReadLine();
    }

    static void Potencia() {
        // 2 elevado a 3 (2^3) = 2 * 2 * 2 = 8
        Console.WriteLine("Potência de um número:");
        Console.WriteLine("Digite a base:");
        int baseNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o expoente:");
        int expo = int.Parse(Console.ReadLine());
        int resultado = (int)Math.Pow(baseNum, expo);
        Console.WriteLine($"O resultado é: {resultado}");
        Console.WriteLine("Aperte ENTER para voltar para o Menu");
        Console.ReadLine();
    }

    static void Raiz() {

        Console.WriteLine("Raiz de um número:");
        Console.WriteLine("Digite o número:");
        int a = int.Parse(Console.ReadLine());
        double resultado = Math.Sqrt(a); // Sqrt Raiz quadrada
        Console.WriteLine($"O resultado é: {resultado}");
        Console.WriteLine("Aperte ENTER para voltar para o Menu");
        Console.ReadLine();

        }

    }
}
