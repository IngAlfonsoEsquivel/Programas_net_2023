// See https://aka.ms/new-console-template for more information
int a1, a2, a3;
Console.Clear();
Console.WriteLine("Dame el angulo 1");
a1=int.Parse(Console.ReadLine());
Console.WriteLine("Dame el angulo 2");
a2=int.Parse(Console.ReadLine());
a3= 180 -(a1+a2);
Console.WriteLine($"El angulo 3 mide {a3}");
