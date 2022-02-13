using Pedro_Gouveia_2019419;

var conta1 = new Conta(1, "Ana", TipoDeConta.ContaSalario);
var conta2 = new Conta(2, "Pedro", TipoDeConta.ContaCorrente);

conta1.Depositar(100);
Console.WriteLine(conta2.Saldo);
conta1.Transferir(100, conta2);
Console.WriteLine(conta2.Saldo);

var clientePremium = new Customer("Jose");
clientePremium.MemberType = MemberType.Premium;
var clienteGold = new Customer("Maria");
clienteGold.MemberType = MemberType.Gold;
var clienteSilver = new Customer("Pedro");
clienteSilver.MemberType = MemberType.Silver;

Console.WriteLine(clientePremium.PrecoComDesconto(40));
Console.WriteLine(clienteGold.PrecoComDesconto(40));
Console.WriteLine(clienteSilver.PrecoComDesconto(40));