using System;


namespace practicingC_
{
    internal class ClienteVip : Pessoa
    {
        public string NivelFidelidade { get; set; }
        public string CodigoVip { get; set; }

        public ClienteVip(string nome, int idade, string nivelFidelidade, string codigoVip) : base(nome, idade)
        {
            NivelFidelidade = nivelFidelidade;
            CodigoVip = codigoVip;
        }
    }
}
