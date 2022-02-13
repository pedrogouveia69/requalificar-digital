using ExsUnipartner;

var c1 = new Cao("12/02/2019", "Bobby", 15);
var c2 = new Cao("8/02/2019", "Jack", 25);
Console.WriteLine(c1.IsObese);
Console.WriteLine(c2.IsObese);


var p1 = new Pessoa("Pedro", 123);
Console.WriteLine(p1.Num_bi = 15033693);


Console.WriteLine(Calculadora.Soma(4, 5));
Console.WriteLine(Calculadora.Multiplicacao(6, 10));


Despertador.Data = "12/02/2019";
Despertador.Hora = "19:45";
Despertador.On();

var arroz = new Produto("arroz cigala", 0.70, 0.10, 2000);
var massa = new Produto("massa milaneza", 0.60, 0.05, 0);
Console.WriteLine(massa.Disponivel);


var bicicleta = new Bicicleta(false, 0, 20);
Console.WriteLine(bicicleta.Ligar());

var automovel = new Automovel(true, 180, "diesel");
Console.WriteLine(automovel.TipoCombustivel);

var navio = new Navio(false, 0);
Console.WriteLine(navio.Ligar());





