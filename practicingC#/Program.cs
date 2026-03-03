using practicingC_;

Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
Console.WriteLine("Veículo: " + veiculo.Placa);
Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual} km/h");

Avaliacao avaliacao = new Avaliacao("Carla Silva");
avaliacao.AtribuirNota(11);   // inválido
avaliacao.AtribuirNota(8.5);  // válido


Agenda agenda = new Agenda("Marina Souza");
agenda.AdicionarContatos(new Contato("Carlos", "11998887777"));
agenda.AdicionarContatos(new Contato("Carlos", "11991112222")); // duplicado
agenda.AdicionarContatos(new Contato("Julia", "21988776655"));
agenda.ListarContatos();

Estudante estudante = new Estudante("Lucas Rocha");
estudante.Nota1 = 7.5;
estudante.Nota2 = 5.0;

Console.WriteLine("Estudante: " + estudante.Nome);
Console.WriteLine("Média: " + estudante.Media.ToString("F2"));
Console.WriteLine("Situação: " + estudante.Situacao);

Calculadora calc = new Calculadora();
Console.WriteLine(calc.Somar(10, 20));
Console.WriteLine(calc.Somar(5, 10, 15));
Console.WriteLine(calc.Somar(3.5, 2.8));


Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());

List<INotificacao> notificacoes = new List<INotificacao>
{
    new Email(),
    new Sms(),
    new Push()
};

foreach (var notificacao in notificacoes)
{
    notificacao.EnviarMensagem("Sistema fora do ar!");
}
List<TarefaAgendada> tarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new RelatorioTarefa(),
    new LimpezaTarefa()
};

foreach (var tarefa in tarefas)
{
    tarefa.Executar();
}
