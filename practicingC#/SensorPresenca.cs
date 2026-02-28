namespace practicingC_
{
    internal class SensorPresenca : ISensor
    {
        public bool Ativar()
        {
            Console.WriteLine("Sensor de presença ativado.");
            return true;
        }
        public bool Desativar()
        {
            Console.WriteLine("Sensor de presença desativado.");
            return true;
        }
    }
}
