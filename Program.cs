// See https://aka.ms/new-console-template for more information
using shape;

//Shape myshape = new Shape();

Shape mycircle1 = new Circle(5.4);
Shape mycircle2 = new Circle(2.5);
Shape myTrianble01 = new Triangle(30,10.2);
Shape myTrianble02 = new Triangle(3.8, 10);


Console.WriteLine("mycircile1:" + mycircle1.area.ToString() + " mycircile2:" + mycircle2.area.ToString());
Console.WriteLine("三角形01:" + myTrianble01.area.ToString() + " 三角形02 :" + myTrianble02.area.ToString());
string msg = "";
if (mycircle1.CompareTo(myTrianble01) == 0)
    msg = "一樣";

if (mycircle1.CompareTo(myTrianble01) > 0)
    msg = "1號圓比較大";

if (mycircle1.CompareTo(myTrianble01) < 0)
    msg = "1號三角形大";
Console.WriteLine(msg);