
namespace Program;

class Program
{
    static void Main()
    {     
        Interface();

    }
    static void Interface()
    {
        bool ativo = true;

        List<Cliente> listaDeCliente = new List<Cliente>();
        


        while (ativo)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----REGISTRO DE CLIENTES----");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"----ESCOLHA UMA OPÇÃO!----");
            Console.WriteLine("1 - REGISTRAR CLIENTE!");
            Console.WriteLine("2 - LISTA DE CLIENTES!");
            Console.WriteLine("3 - SAIR!");
            Console.ForegroundColor = ConsoleColor.White;
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Program.InterfaceCadastro(ativo,listaDeCliente);
                    

                    break;

                case "2":
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("LISTA DOS CLIENTES!");
                    Console.ForegroundColor = ConsoleColor.White;
                    foreach (Cliente cliente in listaDeCliente)
                    {
                        Console.WriteLine($"{cliente.nome} ---- {cliente.numero}");
                    }
                    Console.WriteLine("Pressione qualquer tecla para voltar!");
                    Console.ReadKey();
                    Console.Clear();
                    ativo = true;

                    break;

                case "3":
                    ativo = false;

                    break;


                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("OPÇÃO NÃO ACEITA!");
                    Console.WriteLine("Pressione qualquer tecla para voltar!");
                    Console.ReadKey();
                    Console.Clear();
                    ativo = true;
                    break;
            }



        }


    }
    static void InterfaceCadastro(bool ativo, List<Cliente> clientes)
    {
        Console.Clear();
        Cliente cliente = new Cliente();
        Console.WriteLine("Nome do Cliente:");
        cliente.nome = Console.ReadLine(); 
        Console.WriteLine("Numero do Cliente");
        cliente.numero = Console.ReadLine();
        clientes.Add(cliente);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Cliente adicionado!");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("Pressione qualquer tecla para voltar!");
        Console.ReadKey();
        Console.Clear();
        ativo = true;


    }
}