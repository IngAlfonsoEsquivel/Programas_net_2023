
double l1, l2, h;
Console.Clear();
Console.Write("Dame el lado 1: "); l1= double.Parse(Console.ReadLine());
Console.Write("Dame el lado 2: "); l2= double.Parse(Console.ReadLine());
h=Math.Sqrt ((l1*l1) + (l2 * l2));
Console.WriteLine($"La hipotenusa es {h}");
