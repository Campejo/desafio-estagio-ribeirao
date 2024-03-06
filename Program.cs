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























// //desafio 1
// int indice = 13, soma = 0, k = 0;

// while (k < indice)
// {
//     k += 1;
//     soma += k;
// }

// Console.WriteLine(soma);


// //desafio 2
// Console.WriteLine("Digite um número inteiro maior que 0");
// int x = Convert.ToInt32(Console.ReadLine());

// if(sequenciaDeFibonacci(x))
// {
//     Console.WriteLine($"O número {x} pertence a sequência de Fibonacci");
// }
// else
// {
//     Console.WriteLine($"O número {x} não pertence a sequência de Fibonacci");
// }

// bool sequenciaDeFibonacci(int num)
// {
//     int a = 0;
//     int b = 1;

//     while(b <= num)
//     {
//         if(b == num)
//         {
//             return true;
//         }
        
//         int temporario = a + b;
//         a = b;
//         b = temporario;
//     }

//     return false;
// }


// //desafio 3

// // a) 9
// // b) 128
// // c) 49
// // d) 100
// // e) 13
// // f) 20

// //desafio 4
// // Eu acenderia uma das lâmpadas por um certo tempo, depois desse tempo eu apagaria essa lâmpada e acenderia uma segunda,
// // após isso eu iria até uma das salas das lâmpadas e observaria o seguinte:
// // 1° se a lâmpada estiver acesa eu já sei que foi o interruptor que deixei ligado
// // 2° caso a lâmpada estivesse apagada eu tocaria nela para sentir se estava quente ou fria, caso estivesse
// // fria eu saberia que foi o interruptor que não liguei em momento algum, e caso estivesse quente eu saberia que era o primeiro
// // interruptor que liguei.


// //desafio 5
// Console.WriteLine("Escreva uma palavra");
// string receberString = Console.ReadLine();

// string stringInvertida = InverterString(receberString);

// string InverterString(string palavra)
// {
//     string stringInvertida = "";

//     for(int indice = palavra.Length - 1; indice >= 0; indice --)
//     {
//         stringInvertida += palavra[indice];
//     }
    
//     return stringInvertida;
// }

// Console.WriteLine(stringInvertida);