using System;


namespace practicingC_
{
    internal class ProdutoDigital
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public InformacaoTecnica InfoTecnica { get; set; }

        public ProdutoDigital(string nome, double preco, InformacaoTecnica infoTecninca)
        {
            Nome = nome;
            Preco = preco;
            InfoTecnica = infoTecninca;
        }

        public void ExibirDetalhe()
        {
            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Preço: R${Preco}");
            Console.WriteLine($"Tamanho: {InfoTecnica.TamanhoMB} MB");
            Console.WriteLine($"Compativel com: {InfoTecnica.SistemaOperacional}");
        }
    }
}
