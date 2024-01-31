using EstacionaJá;

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("Bem vindo ao EstacioneJá");

Console.Write("Insira o valor fixo: ");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.Write("Insira o valor por hora: ");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento locacao1 = new (precoHora,precoInicial);

bool repeat = true;

while (repeat)
{
    
    Console.WriteLine("-----------------------------");
    Console.WriteLine("1 -- Adicionar Veiculo");
    Console.WriteLine("2 -- Remover Veiculo");
    Console.WriteLine("3 -- Listar Veiculo");
    Console.WriteLine("4 -- Sair da aplicação");

    switch (Console.ReadLine()) {  
        
        case "1":
            locacao1.adicionarVeiculo();
        break; 
        
        case "2":
            locacao1.removerVeiculo();
            break; 
        
        case "3":
            locacao1.listarVeiculos();
            break;
        
        case "4":
            repeat = false;
            break;
        
        default: 
            Console.WriteLine("Insira uma opção válida!");
            break;
    }
}
