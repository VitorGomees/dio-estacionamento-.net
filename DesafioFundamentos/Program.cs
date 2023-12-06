using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;

//Fiz algumas alterações na "Apresentação"
Console.WriteLine("\n--------------------------------------------\nSeja bem vindo ao sistema de estacionamento!\n--------------------------------------------\n\nDigite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("\nAgora digite o preço por hora:");
precoPorHora = Convert.ToDecimal(Console.ReadLine());

// Instancia a classe Estacionamento, já com os valores obtidos anteriormente
Estacionamento es = new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool exibirMenu = true;

// Realiza o loop do menu
while (exibirMenu)
{
    Console.Clear();

    //Decidi colocar tudo em um Console.WriteLine. Código original comentado.
    Console.WriteLine("----------------------\nDigite a sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar\n----------------------");

    //Console.WriteLine("1 - Cadastrar veículo");
    //Console.WriteLine("2 - Remover veículo");
    //Console.WriteLine("3 - Listar veículos");
    //Console.WriteLine("4 - Encerrar");

    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;

        case "2":
            es.RemoverVeiculo();
            break;

        case "3":
            es.ListarVeiculos();
            break;

        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("\nPressione uma tecla para retornar ao menu");
    Console.ReadLine();
}

Console.WriteLine("O programa se encerrou");
