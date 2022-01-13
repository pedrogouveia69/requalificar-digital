using Ficha4;
using Ficha5;

var a = new Point(0, 0);
var b = new Point(2.5, 5);
var c = new Point(5, 0);

var topLeftPoint = new Point(0, 5);
var r = new Rectangle(topLeftPoint, 5, 5);
var t = new Triangle(a, b, c);   
var circle = new Circle(a, 5);

var fig = new Figure();
fig.Add(t);
fig.Add(circle);
fig.Add(r);

foreach (var shape in fig.Shapes)
{
    Console.WriteLine(shape.getArea());
}
