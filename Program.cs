// See https://aka.ms/new-console-template for more information
using shape;
using System.Net;

//Shape myshape = new Shape();

Shape mycircle1 = new Circle(2.14);
//Shape mycircle2 = new Circle(23.5);
Shape myTrianble01 = new Triangle(9.56,10.8);
//Shape myTrianble02 = new Triangle(36.8, 10);
Shape myTrapezoid01 = new TrapeZoid(19.55, 3.145, 10.9);
//Shape myTrapezoid02 = new TrapeZoid(10, 20, 30);


Console.WriteLine("圓形1:" + mycircle1.area.ToString());
Console.WriteLine("三角形01:" + myTrianble01.area.ToString());
Console.WriteLine("梯形01:" + myTrapezoid01.area.ToString());
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
string msg = "";
if (mycircle1.CompareTo(myTrianble01) == 0)
{
    if (myTrapezoid01.CompareTo(mycircle1) == 0)
        msg = "一樣大";
}
if (mycircle1.CompareTo(myTrianble01) > 0)
{
    if (mycircle1.CompareTo(myTrapezoid01) > 0) msg = "圓比較大";
    else msg = "梯形比較大";
}

if (mycircle1.CompareTo(myTrianble01) < 0)
{
    if(myTrianble01.CompareTo(myTrapezoid01)>0)msg = "三角形比較大"; 
    else msg = "梯形比較大";
}
Console.WriteLine(msg);