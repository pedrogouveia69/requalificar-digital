using Ficha4;


var a = new Point(0, 0);
var b = new Point(2.5, 5);
var c = new Point(5, 0);
//Console.WriteLine(a.getDistanceTo(b));

var topLeftPoint = new Point(0, 5);
var r = new Rectangle(topLeftPoint, 5, 5);
//Console.WriteLine(r.contains(new Point(1, 4)));

var t = new Triangle(a, b, c);
Console.WriteLine(t.Position.X + " " + t.Position.Y);
//Console.WriteLine(t.getPerimeter());   

var circle = new Circle(a, 5);
//Console.WriteLine(circle.ToString());
