using desafio_estagio_ribeirao.Models;

Desafios desafio = new Desafios();

bool exibirMenu = true;

while(exibirMenu)
{
    Console.Clear();
    Console.WriteLine("1 - Desafio 01");
    Console.WriteLine("2 - Desafio 02");
    Console.WriteLine("3 - Desafio 03");
    Console.WriteLine("4 - Desafio 04");
    Console.WriteLine("5 - Desafio 05");
    Console.WriteLine("6 - Sair do menu");

    switch(Console.ReadLine())
    {
        case "1":
            desafio.Desafio01();
            break;
        
        case "2":
            desafio.Desafio02();
            break;
        
        case "3":
            desafio.Desafio03();
            break;
        
        case "4":
            desafio.Desafio04();
            break;
        
        case "5":
            desafio.Desafio05();
            break;

        case "6":
            exibirMenu = false;
            break;
    }
    Console.WriteLine("Digite ENTER para continuar");
    Console.ReadLine();
}