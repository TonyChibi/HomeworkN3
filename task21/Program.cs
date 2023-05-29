//мне не очень нравится мое решение

Console.Clear();
Console.WriteLine("insert coordinates of A dot: ");
int [] a=new int [3];
Console.Write("x: ");
a[0]= int.Parse(Console.ReadLine()!);
Console.Write("y: ");
a[1]= int.Parse(Console.ReadLine()!);
Console.Write("z: ");
a[2]= int.Parse(Console.ReadLine()!);

Console.WriteLine("insert coordinates of B dot: ");
int [] b=new int [3];
Console.Write("x: ");
b[0]= int.Parse(Console.ReadLine()!);
Console.Write("y: ");
b[1]= int.Parse(Console.ReadLine()!);
Console.Write("z: ");
b[2]= int.Parse(Console.ReadLine()!);

Console.WriteLine($"distance between A and B dots equal {Math.Sqrt(Math.Sqrt(Math.Pow((a[0]-b[0]),2)+Math.Pow((a[1]-b[1]),2))+Math.Pow((a[2]-b[2]),2))} ");
