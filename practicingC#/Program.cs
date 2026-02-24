int valorRecebido = 500;
bool doacaoAnonima = true;
char tipoConta = 'P';

Console.WriteLine("Valor recebido: R$" + valorRecebido);
Console.WriteLine("Doação anônima: " + doacaoAnonima);
Console.WriteLine("Tipo da conta " + tipoConta);

int minutos = 250;

int horas = minutos / 60;
int minutosRestantes = minutos % 60;

Console.WriteLine("Tempo: " + horas + " horas e " + minutosRestantes + " minutos");

double largura = 10.5;
double comprimento = 20.3;

double area = largura * comprimento;

Console.WriteLine($"A área do terreno é: {area} metros quadrados. ");

float nota1 = 7.2f;
float nota2 = 8.3f;
float nota3 = 9.1f;

float media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine("A média das notas é: " + media);

decimal pesoContainer = 18.75m;
int veiculosNecessarios = (int) pesoContainer;

Console.WriteLine("Veículos necessários: " + veiculosNecessarios);

int vidaInicial = 5;
vidaInicial--;
vidaInicial++;
vidaInicial++;

int vidaFinal = vidaInicial;
Console.WriteLine("Vidas finais: " + vidaFinal);

decimal salarioAtual = 1500.00m;
int percentualAumento = 10;

salarioAtual = salarioAtual + (salarioAtual * percentualAumento/100);

Console.WriteLine($"O novo salario é de {salarioAtual.ToString("F2")}");

double pi = 3.14159;
double raio = 5;
double areaC = pi * raio * raio;
double perimetro = 2 * pi * raio;

Console.WriteLine("Raio: " + raio);
Console.WriteLine("Área do círculo: " + areaC.ToString("F2"));
Console.WriteLine("Perímetro do círculo: " + perimetro.ToString("F2"));

double saldo = 0;

if (saldo > 0)
{
    Console.WriteLine("Saldo positivo!");
}
else if (saldo < 0)
{
    Console.WriteLine("Saldo negativo!");
}
else
{
    Console.WriteLine("Saldo zero!");
}

int codigo;
Console.Write("Digite o código do produto (1 ou 2): ");
codigo = int.Parse(Console.ReadLine());

if (codigo == 1)
{
    Console.WriteLine("Perecível");
}
else if (codigo == 2)
{
    Console.WriteLine("Não perecível");
}
else
{
    Console.WriteLine("Numero Invalido!");
}

Console.WriteLine("Informe a nota final do aluno: ");
double notas = double.Parse(Console.ReadLine());

if (notas >= 9)
{
    Console.WriteLine("O aluno recebeu a nota A.");
}
else if (notas >= 7)
{
    Console.WriteLine("O aluno recebeu a nota B.");
}
else if(notas >= 5)
{
    Console.WriteLine("O aluno recebeu a nota C.");
}
else
{
    Console.WriteLine("O aluno recebeu a nota D.");
}

int valorVenda, soma = 0;
do
{
    Console.Write("Digite o valor da venda (ou 0 para encerrar): ");
    valorVenda = int.Parse(Console.ReadLine());
    soma += valorVenda;
}
while (valorVenda > 0 && valorVenda != 0);
Console.WriteLine("Total de vendas do dia: R$" + soma);


int quantidade, estoque = 0;
Console.WriteLine("Deseja adicionar um produto ao estoque?");
Console.WriteLine("1 - Sim | 0 - Não");
int resposta = int.Parse(Console.ReadLine());
while (resposta != 0)
{
    Console.WriteLine("Quantidade:");
    quantidade = int.Parse(Console.ReadLine());
    estoque += quantidade;
    Console.Write("Estoque atual: " + estoque);
    Console.WriteLine();
    Console.WriteLine("Deseja continuar? ");
    Console.WriteLine("1 - Sim | 0 - Não");
    resposta = int.Parse(Console.ReadLine());
}
Console.WriteLine("Obrigado por usar nosso sistema de estoque!");


List<string> alunos = new List<string> { "Ana", "Carlos", "Bianca", "João", "Marina" };

Console.WriteLine("Digite o nome do aluno:");
string nomeBusca = Console.ReadLine();
int indice = 0;
bool encontrado = false;

while (indice < alunos.Count)
{
    if (alunos[indice] == nomeBusca)
    {
        encontrado = true;
        break;
    }
    indice++;
}

if (encontrado)
{
    Console.WriteLine($"Aluno encontrado na posição: {indice}");
}
else
{
    Console.WriteLine("Aluno não está presente na lista");
}

int senhaGerada = 0;
int senhaAtual = 0;
int opcao;
do
{
    Console.WriteLine("1 - Gerar nova senha");
    Console.WriteLine("2 - Chamar próxima senha ");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            senhaGerada++;
            Console.WriteLine("Senha gerada: " + senhaGerada.ToString("D3"));
            break;

        case 2:
            senhaAtual++;
            Console.WriteLine("Senha chamada: " + senhaAtual.ToString("D3"));
            break;
        case 3:
            Console.WriteLine("Encerrando o programa. Obrigado!");
            break;
    }
} while(opcao != 3);

int opcao;
do
{
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());
 
    switch (opcao)
    {
        case 1:
            Console.Write("Digite a temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine($"{celsius}°C equivalem a {fahrenheit}°F");
            break;
        case 2:
            Console.Write("Digite a temperatura em Fahrenheit: ");
            double fahr = double.Parse(Console.ReadLine());
            double cel = (fahr - 32) * 5 / 9;
            Console.WriteLine($"{fahr}°F equivalem a {cel}°C");
            break;
        case 3:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
} while (opcao != 3);


for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}


for (int i = 1; i <= 10; i++)
{
    int multiplo = 7 * i;
    Console.WriteLine($"7 x {i} = {multiplo}" );
}


List<int> notas = new List<int> { 4, 7, 5, 9, 6 };

for (int i = 0; i < notas.Count; i++)
{
    if (notas[i] < 6)
    {
        Console.WriteLine($"Nota {notas[i]} - Reprovado");
    }
    else
    {
        Console.WriteLine($"Nota {notas[i]} - Aprovado");
    }
}

List<double> notas = new List<double>
{
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
};
 
double mediaCorte = 7.0;
 
foreach (var nota in notas)
{
    if (nota < mediaCorte)
    {
        Console.WriteLine($"O aluno com a nota {nota} está abaixo da média!");
    }
 
    else
    {
        Console.WriteLine($"O aluno com a nota {nota} está indo muito bem!");
    }
}



