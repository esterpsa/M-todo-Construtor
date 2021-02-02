using System;
using Construtores.classes;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pessoa p = new Pessoa("Ester", "Albuquerque");

            // Console.WriteLine($"Bem-Vindo {p.Nome} {p.Sobrenome}");

            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            Pessoa ester = new Pessoa(nome, sobrenome);

            ester.Calcular(20, 22);

        

            

            

            
        }
    }
}
