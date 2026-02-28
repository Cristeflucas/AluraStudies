namespace practicingC_
{
    internal class Computador
    {
        public Processador Processador { get; set; }
        public PlacaMae PlacaMae { get; set; }

        public Computador(Processador processador, PlacaMae placaMae)
        {
            Processador = processador;
            PlacaMae = placaMae;
        }

        public void ExibirConfiguracao()
        {
            Console.WriteLine("Computador configurado com:");
            Console.WriteLine($"Processador: {Processador.Marca} - {Processador.Modelo}");
            Console.WriteLine($"Placa-mãe: {PlacaMae.Fabricante} - {PlacaMae.Socket}");
        }
    }
}
