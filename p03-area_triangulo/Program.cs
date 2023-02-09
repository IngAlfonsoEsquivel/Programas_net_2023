// See https://aka.ms/new-console-template for more information
int ba, al;
float area;
Console.Clear();
Console.WriteLine("Calculando el area de un  triagulo ");
Console.Write("Dame la base ");
ba=int.Parse(Console.ReadLine());
Console.Write("Dame la altura ");
al=int.Parse(Console.ReadLine());
area = (ba * al) / 2;
Console.WriteLine($"El area del triangulo es {area} ");
