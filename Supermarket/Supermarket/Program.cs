using Supermarket;

var priorityRegister = new Register(RegisterType.PRIORITY);

var debora = new Employee(1, "debora");
var joana = new Employee(2, "joana");

var maria = new Costumer(123, false);
var jose = new Costumer(321, false);
var sara = new Costumer(132, true);

maria.AddToShoppingCart(new Product(1, "arroz", 0.5));
maria.AddToShoppingCart(new Product(2, "massa", 0.4));

debora.OpenRegister(priorityRegister);

maria.WaitInLine(priorityRegister);
jose.WaitInLine(priorityRegister);
sara.WaitInLine(priorityRegister);

foreach (var costumer in priorityRegister.WaitingLine)
{
    priorityRegister.Employee.ScanProducts(costumer.ShoppingCart);
}

priorityRegister.ChangeEmployee(joana);
joana.CloseRegister(priorityRegister);

foreach (var item in priorityRegister.Log)
{
    Console.WriteLine(item);
}


