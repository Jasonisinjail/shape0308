// See https://aka.ms/new-console-template for more information
using shape;

//Shape myshape = new Shape();

Shape mycircle1 = new Circle(5.4);
Shape myTrianble01 = new Triangle(10.2, 10.2);
Shape myTrapeZoid01 = new TrapeZoid(19.9, 10.64, 10.85);


Console.WriteLine("圓形面積:" + mycircle1.area.ToString());
Console.WriteLine("三角形面積:" + myTrianble01.area.ToString());
Console.WriteLine("梯形形面積:" + myTrapeZoid01.area.ToString());
string msg = "";
if (mycircle1.CompareTo(myTrianble01) == 0)
{ 
    if(mycircle1.CompareTo(myTrapeZoid01) ==0)msg = "一樣大";
}
if (mycircle1.CompareTo(myTrianble01) > 0)
{
    if (mycircle1.CompareTo(myTrapeZoid01) > 0) msg = "圓比較大";
    else msg = "梯型比較大";
}
if (mycircle1.CompareTo(myTrianble01) < 0)
{
    if (myTrianble01.CompareTo(myTrapeZoid01) >0) msg = "三角形大";
    else msg = "梯形比較大";
}
Console.WriteLine(msg);