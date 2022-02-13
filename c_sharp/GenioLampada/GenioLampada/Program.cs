using GenioLampada;

var lamp = new MagicLamp(3); //instanciar -> criar um novo objeto


while (true)
{
    Console.WriteLine("Available Genies: " + lamp.NumberOfGenies);
    Console.WriteLine("1. Rub\n2. Recharge");
    int option = int.Parse(Console.ReadLine());
    if (option == 1)
    {
        Console.WriteLine("How many times do you wish to rub?");
        int rubNum = int.Parse(Console.ReadLine());
        Console.WriteLine("How many wishes do you want?");
        int numberOfWishes = int.Parse(Console.ReadLine());

        lamp.rub(rubNum, numberOfWishes);
    }
    else if (option == 2)
    {
        if (lamp.NumberOfGenies > 0)
        {
            Console.WriteLine("Can't recharge.");
        }
        else
        {
            lamp.recharge();
        }
    }
}




