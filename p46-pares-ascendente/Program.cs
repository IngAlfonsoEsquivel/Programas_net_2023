int c,n,s;
char resp;
do{


    Console.Clear();
    Console.WriteLine("Imprime los numeros pares de 2 a n, calcula la suma, el proceso se repite ");
    Console.Write("Hasta donde deseas los pares? "); n= int.Parse(Console.ReadLine());
    c=2;
    s=0;
    while (c<= n){
        Console.Write($"{c} ");
        s+= c;
        c+= 2;
    }
    Console.WriteLine($" La suma de los pares de 2 a {n} es {s}");
    Console.WriteLine(" Deseas continuar? (S/N)"); resp=char.ToUpper(Console.ReadLine()[0]);
} while(resp!= 'N');
Console.WriteLine("Proceso Terminado ....");