using System;

namespace practicingC_
{
    internal class Email : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando email com a mensagem: {mensagem}");
        }
    }
}
