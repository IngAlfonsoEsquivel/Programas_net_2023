
int horas, minutos, segundos, dias;
Console.Clear();
System.Console.WriteLine("Muestras las horas en minutos, segundos y dias");
System.Console.Write("Ingrese cantidad de horas: ");
horas = int.Parse(Console.ReadLine());
minutos = horas * 60;
dias = horas / 24;
segundos = horas * 3600;
System.Console.WriteLine($"Minutos: {minutos}");
System.Console.WriteLine($"Dias: {dias}");
System.Console.WriteLine($"Segundos: {segundos}");