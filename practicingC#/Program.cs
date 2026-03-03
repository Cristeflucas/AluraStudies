/*using practicingC_;

Veiculo veiculo = new Veiculo("ABC-1234");
veiculo.AtualizarVelocidade(72.5);
Console.WriteLine("Veículo: " + veiculo.Placa);
Console.WriteLine($"Velocidade atual: {veiculo.VelocidadeAtual} km/h");
using practicingC_;

Avaliacao avaliacao = new Avaliacao("Carla Silva");
avaliacao.AtribuirNota(11);   // inválido
avaliacao.AtribuirNota(8.5);  // válido
*/

using practicingC_;

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