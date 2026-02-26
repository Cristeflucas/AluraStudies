using practicingC_;



Livro livro1 = new Livro();
livro1.Titulo = "Dom Casmurro";
livro1.Autor = "Machado de Assis";

Console.WriteLine("Livro: " + livro1.Titulo);
Console.WriteLine("Autor: " + livro1.Autor);

Passagem passagem1 = new Passagem("Lucas Souza", "Paris");

Console.WriteLine("Passageiro: " + passagem1.Passageiro);
Console.WriteLine("Destino: " + passagem1.Destino);

ContaBancaria conta1 = new ContaBancaria(12345, 1000.0);
conta1.Depositar(500.0);

Console.WriteLine("Conta: " + conta1.NumeroConta);
Console.WriteLine("Saldo atual: " + conta1.Saldo);


Funcionario func = new Funcionario("Carlos Pereira", "Assistente Administrativo");
func.Promover("Assistente Administrativo");
func.Promover("Analista de Projetos");

Console.WriteLine("Funcionário: " + func.Nome);
Console.WriteLine("Cargo Atual: " + func.Cargo);

InformacaoTecnica info = new InformacaoTecnica(1500, "Windows");
ProdutoDigital produto = new ProdutoDigital("Software de Edição de Vídeo", 299.99, info);
produto.ExibirDetalhe();


