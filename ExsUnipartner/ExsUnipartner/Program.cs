using ExsUnipartner;

var c1 = new Cao("12/02/2019", "Bobby", 15);
var c2 = new Cao("8/02/2019", "Jack", 25);

Console.WriteLine(c1.isObese());
Console.WriteLine(c2.isObese());

var p1 = new Pessoa("Pedro", 123);
Console.WriteLine(p1.Num_bi = 15033693);

Calculadora.Soma(4, 5);
Calculadora.Multiplicacao(6, 10);


Console.WriteLine(Despertador.Data = "12/02/2019");
Console.WriteLine(Despertador.Hora = "19:45");
Despertador.on();

var arroz = new Produto("detalhes do arroz", 2, 0.05f, 200);
var massa = new Produto("detalhes da massa", 2, 0, 0);

var bicicleta = new Bicicleta(false, 0, 20);
bicicleta.ligar();

var automovel = new Automovel(true, 180, "diesel");
Console.WriteLine(automovel.TipoCombustivel);

var navio = new Navio(false, 0);
navio.ligar();





