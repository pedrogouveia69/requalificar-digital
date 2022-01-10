using Ficha4;

var p1 = new Point(5, 10);
var p2 = new Point(1, 6);
var p3 = new Point(2, 3);

//Console.WriteLine(p1.getDistanceTo(p2));

var t1 = new Triangle(p1, p2, p3);
//Console.WriteLine(t1.A.X + " " + t1.A.Y);

var topLeftPoint = new Point(0, 5);
var r1 = new Rectangle(topLeftPoint, 5, 5);

//Console.WriteLine(r1.calculatePerimeter());


Console.WriteLine(r1.contains(new Point(1, 4)));