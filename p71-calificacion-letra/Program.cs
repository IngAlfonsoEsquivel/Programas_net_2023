﻿int i,j,n,m;
char  resp;
do {
Console.Clear();
Console.Write("Cuantos renglones ? "); n = int.Parse(Console.ReadLine());
for(i=1; i<=n; i++) {
for(j=1; j<=i; j++) {
Console.Write($"{i} ");
}
Console.WriteLine();
}
Console.Write("\nDeseas continuar (S/N) ?");resp=char.ToUpper(Console.ReadLine()[0]);
} while( resp!= 'N');
Console.WriteLine("\nAhi tamos");