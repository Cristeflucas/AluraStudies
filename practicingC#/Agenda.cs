using System;
namespace practicingC_
{
    internal class Agenda
    {
        public string Propietario { get; set; }
        private readonly List<Contato> contatos;

        public Agenda(string propietario)
        {
            Propietario = propietario;
            contatos = new List<Contato>();
        }

        public bool AdicionarContatos(Contato contato)
        {
            if (contatos.Any(c => c.Nome == contato.Nome ))
            {
                Console.WriteLine("Contato já existe: ");
                return false;
            }
            contatos.Add(contato);
            return true;
        }
        public void ListarContatos()
        {
            Console.WriteLine("Contatos da agenda de " + Propietario + ":");
            foreach (var contato in contatos)
            {
                Console.WriteLine("Nome: " + contato.Nome + ", Telefone: " + contato.Telefone);
            }
        }
    }
}
