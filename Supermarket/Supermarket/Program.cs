using Supermarket;

var caixaP = new CaixaPrioritaria();

var debora = new Employee("debora", 1);

var maria = new Costumer("maria", false);
var jose = new Costumer("jose", false);
var sara = new Costumer("sara", true);

maria.AddToShoppingCart(new Product("arroz", 0.5));
maria.AddToShoppingCart(new Product("massa", 0.4));

caixaP.Open(debora);

caixaP.AddToWaitingLine(maria);
caixaP.Employee.ScanProducts(maria.ShoppingCart);
caixaP.RemoveFromWaitingLine(maria);

caixaP.AddToWaitingLine(jose);
caixaP.AddToWaitingLine(sara);

foreach (var costumer in caixaP.WaitingLine)
{
    Console.WriteLine(costumer.Name);
}
