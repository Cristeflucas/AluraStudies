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

