using System;


namespace practicingC_
{
    internal class ContaBancaria
    {
        public int NumeroConta { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria(int numeroConta, double saldo)
        {
            NumeroConta = numeroConta;
            Saldo = saldo;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
    }
}
