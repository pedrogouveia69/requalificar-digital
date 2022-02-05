void tabuada(int n)
{
    if (n >= 1 && n < 10)
    {
        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(n + "*" + i + "=" + (n * i));
        }
    }
    else
    {
        Console.WriteLine("o num tem que ser >= 1 e <10");
    }
}


void inserirDados(float[] v)
{

    for (int i = 0; i < v.Length; i++)
    {
        Console.WriteLine("insira o {0}º num:", i + 1);
        int userInput = int.Parse(Console.ReadLine());
        v[i] = userInput;
    }
}

void imprimeDados(float[] v)
{
    foreach (int value in v)
    {
        Console.Write(value + " ");
    }
}

void resultados(float[] notas)
{
    int exc = 0;
    int mb = 0;
    int b = 0;
    int s = 0;
    int rep = 0;
    float soma = 0;

    foreach (float nota in notas)
    {
        soma += nota;
        switch (nota)
        {
            case >= 18:
                exc++;
                break;
            case >= 15:
                mb++;
                break;
            case >= 12:
                b++;
                break;
            case >= 10:
                s++;
                break;
            default:
                rep++;
                break;
        }
    }

    Console.WriteLine
    (
        "Houve {0} alunos que tiveram nota superior ou igual a 18, {1} com nota entre 15 e 18, {2} com nota entre 12 e 15, {3} com nota entre 10 e 12 e {4} que reprovaram.",
        exc, mb, b, s, rep
    );

    Console.WriteLine("A media é: " + soma / notas.Length);
    Console.WriteLine("Numero de alunos acima da media: " + acimaDaMedia(notas, soma / notas.Length));
}

int acimaDaMedia(float[] notas, float media)
{
    int count = 0;
    foreach (float nota in notas)
    {
        if (nota > media)
        {
            count++;
        }
    }
    return count;
}

float imc(float peso, float altura)
{
    double imc = peso / Math.Pow(altura, 2);
    return (float)imc;
}

void escreveCategoria(float imc)
{
    if (imc < 19)
    {
        Console.WriteLine("Magro" + imc);
    } 
    else if (imc >= 19 || imc <= 25)
    {
        Console.WriteLine("Normal" + imc);
    }
    else if (imc <= 30)
    {
        Console.WriteLine("Excesso de peso" + imc);
    }
    else if (imc <= 40)
    {
        Console.WriteLine("Obeso" + imc);
    }
    else
    {
        Console.WriteLine("Obesidade Mórbida" + imc);
    }
}

//escreveCategoria(imc(75, 1.78f));

    /*
double imc2(float peso, float altura)
{
    return peso / Math.Pow(altura, 2);
}
    */

//tabuada(6);

/*
float[] notas = new float[20];
inserirDados(notas);
//imprimeDados(notas);

resultados(notas);
*/
