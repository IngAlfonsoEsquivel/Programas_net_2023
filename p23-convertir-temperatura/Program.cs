char op;
float temp, res;
Console.Clear();
Console.WriteLine("Convertir de grados celcius a farenheit y viceversa\n");
Console.WriteLine("[F]arenheit a Centigrados");
Console.WriteLine("[C]entigrados a Farenheit ");
Console.Write("Elije una opcion ? ");
op=char.ToUpper(Console.ReadLine()[0]);

if( op=='F' ) {
Console.WriteLine("\nConvertir a Farenheit\n");
Console.Write("Dame los grados Celsius ? "); temp=float.Parse(Console.ReadLine());
res = ( temp * 9 / 5 ) + 32;
Console.WriteLine($"{temp} Centigrados, equivale a {res} Farenheit");
}
else {
Console.WriteLine("\nConvertir a Centigrados\n");
Console.WriteLine("Dame los grados Farenheit ? "); temp=float.Parse(Console.ReadLine());
res = ( temp - 32 ) * 5 / 9;
Console.WriteLine($"{temp} Farenheit, equivale a {res} Centigrados");
}
Console.WriteLine("\nGracias por utilizar este programa");