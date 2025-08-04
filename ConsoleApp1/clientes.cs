public class Cliente
{
    public string nome { get; set; }
    public string numero { get; set; }   

    public void InterfaceCadastro()
    {
        Cliente cliente = new Cliente();
        Console.WriteLine("Nome do Cliente:");
        cliente.nome = Console.ReadLine();
        Console.WriteLine("Numero do cliente");
        cliente.numero = Console.ReadLine();
    }
    
}
