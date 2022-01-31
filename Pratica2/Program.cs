int Ex1()
{
    Console.WriteLine("insira o 1º num:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("insira o 2º num:");
    int b = int.Parse(Console.ReadLine());

    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}

double Ex2()
{
    Console.WriteLine("insira temp Fahrenheit:");
    float tempF = float.Parse(Console.ReadLine());
    return (tempF - 32) * 5 / 9;

}
string Ex3()
{
    Console.WriteLine("insira um num:");
    int num = int.Parse(Console.ReadLine());

    //short if https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
    return num % 2 == 0 ? "numero par" : "numero impar";
}

string Ex4()
{
    Console.WriteLine("insira um ano:");
    int ano = int.Parse(Console.ReadLine());
    if
    (
        ano % 4 == 0 ||
        (ano % 4 == 0 && ano % 100 != 0) ||
        (ano % 100 == 0 && ano % 400 == 0)
    )
    {
        return "ano bissexto";
    }
    return "ano nao bissexto";

}

string Ex5()
{
    List<int> list = new List<int>();
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("insira o {0}º numero:", i);
        int num = int.Parse(Console.ReadLine());
        list.Add(num);
    }
    list.Sort();
    return "minimo: " + list.First() + ", maximo: " + list.Last();
}

void Ex6()
{
    for(int i = 19; i <= 2000; i+=19)
    {
        Console.WriteLine(i); 
    }
}

int Ex7()
{
    int soma = 0;
    while (true)
    {
        Console.WriteLine("insira um num:");
        int num = int.Parse(Console.ReadLine());
        soma += num;

        if (num < 0)
        {
            break;
        }
    }
    return soma;
}

//Ex6();
Console.WriteLine(Ex7());