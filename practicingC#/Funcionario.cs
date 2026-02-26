using System;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace practicingC_
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }

        public Funcionario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

        public void Promover(string novoCargo)
        {
            if (novoCargo == Cargo)
            {
                Console.WriteLine("Erro: O novo cargo deve ser diferente do cargo atual."); 
            }
            else
            {
                Cargo = novoCargo;
                Console.WriteLine("Promoção realizada com sucesso!");
            }
        }
    }
}
