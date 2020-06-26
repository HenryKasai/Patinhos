using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool terminar = false;
            int patinhos;
            while (!terminar)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Quantos patinhos irão passear? ");
                bool patinhosbool = Int32.TryParse(Console.ReadLine(), out patinhos);
                int todos = patinhos;
                if(!patinhosbool)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Por favor, insira um número.");
                    Console.WriteLine("Pressione uma tecla para inserir outro valor.");
                    Console.ReadKey();
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (patinhos == 1)
                {
                    Console.WriteLine($"1 patinho foi passear");
                    Console.WriteLine($"Além das montanhas");
                    Console.WriteLine($"Para brincar");
                    Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                    Console.WriteLine($"Mas só 1 patinho voltou de lá.\n");
                    Console.WriteLine($"A mamãe patinha foi procurar");
                    Console.WriteLine($"Além das montanhas");
                    Console.WriteLine($"Na beira do mar");
                    Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                    Console.WriteLine($"E o patinho voltou de lá.\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Pressione uma tecla para finalizar o programa.");
                    terminar = true;
                }
                else
                {
                    for (int i = 1; i <= patinhos; i++)
                    {
                        Console.WriteLine($"{patinhos} patinhos foram passear");
                        Console.WriteLine($"Além das montanhas");
                        Console.WriteLine($"Para brincar");
                        Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                        Console.WriteLine($"Mas só {patinhos} patinhos voltaram de lá.\n");
                        patinhos--;
                    }
                    Console.WriteLine($"1 patinho foi passear");
                    Console.WriteLine($"Além das montanhas");
                    Console.WriteLine($"Para brincar");
                    Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                    Console.WriteLine($"Mas só 1 patinho voltou de lá.\n");
                    Console.WriteLine($"A mamãe patinha foi procurar");
                    Console.WriteLine($"Além das montanhas");
                    Console.WriteLine($"Na beira do mar");
                    Console.WriteLine($"A mamãe gritou: Quá, quá, quá, quá");
                    Console.WriteLine($"E os {todos} patinhos voltaram de lá.\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Pressione uma tecla para finalizar o programa.");
                    Console.ReadKey();
                    terminar = true;
                }
            }
        }
    }
}
