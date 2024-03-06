# Testes - Estágio Ribeirão Preto

## 1° Desafio:
    int indice = 13, soma = 0, k = 0;

    while (k < indice)
    {
        k += 1;
        soma += k;
    }

    Console.WriteLine(soma);

## 2° Desafio:

    Console.WriteLine("Digite um número inteiro maior que 0");
    int x = Convert.ToInt32(Console.ReadLine());

    if(sequenciaDeFibonacci(x))
    {
        Console.WriteLine($"O número {x} pertence a sequência de Fibonacci");
    }
    else
    {
        Console.WriteLine($"O número {x} não pertence a sequência de Fibonacci");
    }

    bool sequenciaDeFibonacci(int num)
    {
        int a = 0;
        int b = 1;

        while(b <= num)
        {
            if(b == num)
            {
                return true;
            }
        
            int temporario = a + b;
            a = b;
            b = temporario;
        }

        return false;
    }



## 3° Desafio:

     a) 9
     b) 128
     c) 49
     d) 100
     e) 13
     f) 20

## 4° Desafio:

Eu acenderia uma das lâmpadas por um certo tempo, depois desse tempo eu apagaria essa lâmpada e acenderia uma segunda, após isso eu iria até uma das salas das lâmpadas e observaria o seguinte:

1. Se a lâmpada estiver acesa eu já sei que foi o interruptor que deixei ligado.

2. Caso a lâmpada estivesse apagada eu tocaria nela para sentir se estava quente ou fria, caso estivesse fria eu saberia que foi o interruptor que não liguei em momento algum, e caso estivesse quente eu saberia que era o primeiro interruptor que liguei.

## 5° Desafio:
    Console.WriteLine("Escreva uma palavra");
    string receberString = Console.ReadLine();

    string stringInvertida = InverterString(receberString);

    string InverterString(string palavra)
    {
        string stringInvertida = "";

        for(int indice = palavra.Length - 1; indice >= 0; indice --)
        {
            stringInvertida += palavra[indice];
        }
    
        return stringInvertida;
    }

    Console.WriteLine(stringInvertida);



