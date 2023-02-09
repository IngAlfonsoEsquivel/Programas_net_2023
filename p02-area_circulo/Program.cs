// See https://aka.ms/new-console-template for more information
double area, radio;

Console.WriteLine("Calculando el area de un cirul: ");
Console.Write("Dame el radio: ");
radio = double.Parse(Console.ReadLine());
area = Math.PI * Math.Pow(radio,2);
Console.WriteLine($"Elciculo de radio {radio} tiene un area de {area}");
