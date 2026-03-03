using System;

namespace practicingC_
{
    internal class Sms : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando SMS com a mensagem: {mensagem}");
        }
    }
}
