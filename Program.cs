Console.Write("a: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("b: ");
double b = Convert.ToDouble(Console.ReadLine());
double solution;
if (a == 0)
{
    if (b == 0)
    {
        Console.WriteLine("vo so nghiem");
    }
    else
    {
        Console.WriteLine("vo nghiem");
    }
}
else
{
    if (b == 0)
    {
        Console.WriteLine("ket qua: 0");
    }
    else
    {
        solution = -b / a;
        Console.WriteLine("ket qua: " + solution);
    }

}
