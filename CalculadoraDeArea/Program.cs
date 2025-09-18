using System;

namespace CalculadoraDeArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Opcao();
        }

        static void Opcao()
        {
            Console.WriteLine("Opções:\n1- Quadrado/Retângulo\n2- Triângulo\n3- Círculo\n4- Trapézio\n5- Sair");
            string opcao = Console.ReadLine();

            switch(opcao)
            {
                case "1":
                    Quadrado();
                    break;
                case "2":
                    Triangulo();
                    break;
                case "3":
                    Circulo();
                    break;
                case "4":
                    Trapezio();
                    break;
                case "5":
                    Console.WriteLine("Encerrando o programa...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Selecione uma opção válida");
                    Opcao();
                    break;
            }
        }

        static public void Quadrado()
        {
            Console.WriteLine("Digite o lado A");
            float aQ = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o lado B");
            float bQ = float.Parse(Console.ReadLine());
            float resultadoQ = aQ*bQ;
            Console.WriteLine($"A área do quadrado ou retângulo é igual a '{resultadoQ}'");
            
            Opcao();
        }

        static public void Triangulo()
        {
            Console.WriteLine("Digite o valor da Base");
            float baseT = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da Altura");
            float alturaT = float.Parse(Console.ReadLine());
            float resultadoT = (baseT*alturaT)/2;

            Console.WriteLine($"A área do triângulo é igual a '{resultadoT}'");

            Opcao();
        }

        static public void Circulo()
        {
            Console.WriteLine("Digite o valor do Raio");
            float raioC = float.Parse(Console.ReadLine());
            double resultadoC = Math.Round(Math.PI * Math.Pow(raioC, 2), 2);
            Console.WriteLine($"A área do círculo é igual a '{resultadoC}'");
            
            Opcao();
        }

        static public void Trapezio()
        {
            Console.WriteLine("Digite o valor da Base Maior");
            float baseMaior = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da Base Menor");
            float baseMenor = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da Altura");
            float alturaT = float.Parse(Console.ReadLine());

            double resultadoT = ((baseMaior + baseMenor) * alturaT) / 2;
            Console.WriteLine($"A área do trapézio é igual a '{resultadoT}'");

            Opcao();
        }
    }
}