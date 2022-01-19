using GenioLampada;

var lamp = new MagicLamp(4);

lamp.rub(3, 3);
Console.WriteLine(lamp.NumberOfGenies);
lamp.rub(4, 3);
lamp.rub(4, 3);
lamp.rub(4, 3);
lamp.rub(4, 3);
lamp.rub(4, 3);
lamp.recharge();
Console.WriteLine(lamp.RechargeCounter);
lamp.rub(3, 3);

