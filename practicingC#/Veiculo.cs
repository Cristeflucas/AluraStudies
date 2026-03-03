using System;

namespace practicingC_
{
    internal class Veiculo
    {
        public string Placa { get; set; }
        public double VelocidadeAtual {  get; private set; }

        public Veiculo (string placa)
        {
            Placa = placa;
            VelocidadeAtual = 0;
        }

        public double AtualizarVelocidade(double novaVelocidade)
        {
            return VelocidadeAtual = novaVelocidade;
        }


    }
}
