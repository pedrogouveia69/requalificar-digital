//int num = número que é pedido ao user

void Ex8()
{
    double salario = 1000;
    double aumentoPercentagem = 0.015;

    for (int ano = 1996; ano <= 2000; ano++)
    {
        Console.WriteLine(ano + "-> " + (salario + salario * aumentoPercentagem) + "$");
        aumentoPercentagem *= 2;
    }
}

void Ex9()
{
    int num = 21;
    for (int i = num - 1; i > 1; i--)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
}

void Ex11()
{
    double num = 5;
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine(Math.Pow(i, 3));
    }
}

void Ex12()
{
    for (int i = 40; i >= 20; i -= 2)
    {
        Console.WriteLine(i);
    }
}

void Ex13()
{
    int num = 21;
    string asterisks = "*";
    for (int i = 0; i < num; i++)
    {
        for (int j = num - 1; j > i; j--)
        {
            Console.Write(" ");
        }
        Console.WriteLine(asterisks);
        asterisks += "**";
    }
}

void Ex14()
{
    int num = 6;
    for(int i = 1; i <= num; i++)
    {
        for(int j = 0; j < i; j++)
        {
            Console.Write(i);
        }
        Console.WriteLine();
    }
}

void Ex15()
{
    int num = 3;
    int displayNum = 0;
    for (int i = 0; i < num; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write(++displayNum);
        }
        Console.WriteLine();
    }
}

void Ex17()
{
    int num = 5;
    int res = num;
    for (int i = num - 1; i > 1; i--)
    {
        res *= i;
    }
    Console.Write(res);
}

void Ex18()
{
    int num = 3;
    string str = "";
    int soma = 0;
    for (int i = 0; i < num; i++)
    {
        str += "9";
        soma += int.Parse(str);
    }
    Console.WriteLine(soma);
}

Ex8();