using System;

namespace practicingC_
{
    internal class Push : INotificacao
    {
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando notificação push com a mensagem: {mensagem}");
        }
    }
}
