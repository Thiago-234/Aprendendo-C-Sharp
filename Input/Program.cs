using System;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo! {nome}");
        }
    }
}