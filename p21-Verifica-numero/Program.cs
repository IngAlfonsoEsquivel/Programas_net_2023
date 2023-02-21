// See https://aka.ms/new-console-template for more information
int n;
Console.Clear();
Console.WriteLine("Verifica si un numero es positivo, negativo o cero ");
Console.Write("Dame un numero ? ");
n=int.Parse(Console.ReadLine());
if(n>0)
Console.WriteLine("El número es POSITIVO \n");
if(n<0)
Console.WriteLine("El número es NEGATIVO \n");
if(n==0)
Console.WriteLine("El número es CERO \n");
Console.WriteLine("\nGracias por utilizar el programita ");
