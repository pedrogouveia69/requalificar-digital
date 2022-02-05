using GenioLampada;

var lamp = new MagicLamp(3); //instanciar -> criar um novo objeto


while (true)
{
    Console.WriteLine("Numero de genios disponiveis " + lamp.NumberOfGenies);
    Console.WriteLine("1. Esfregar\n2. Recarregar");
    //Console.WriteLine("1. Esfregar\n2. Recarregar\n3. Ver Todos os Desejos");
    int option = int.Parse(Console.ReadLine());
    if (option == 1)
    {
        Console.WriteLine("Qtas vezes quer esfregar?");
        int rubNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Qtos desejos quer?");
        int numberOfWishes = int.Parse(Console.ReadLine());

        lamp.rub(rubNum, numberOfWishes);
    }
    else if (option == 2)
    {
        if (lamp.NumberOfGenies > 0)
        {
            Console.WriteLine("Nao é possivel recarregar");
        }
        else
        {
            lamp.recharge();
        }

    }
    /*
    else if (option == 3)
    {
        foreach (var item in lamp.GoodGenie.Wishes)
        {
            Console.WriteLine(item);
        }
    }
    */

}
lamp.rub(3, 3); //bom
lamp.rub(3, 3); //demon
lamp.recharge();
lamp.rub(2, 3);// mau
lamp.rub(3, 3); //demon


int i; //declarar
i = 0; //inicializar

MagicLamp lamp2; //declarar
lamp2 = new MagicLamp(4); // incializar




