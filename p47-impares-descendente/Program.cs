int c,n,s;
char resp;
do{


    Console.Clear();
    Console.WriteLine("Imprime los numeros inpares de n a 1, calcula la suma, el proceso se repite ");
    Console.Write("Hasta donde deseas los pares? "); n= int.Parse(Console.ReadLine());
    c=(n%2==0 ? --n: n);
    s=0;
    while (c>= 1){
        Console.Write($"{c} ");
        s+= c;
        c-= 2;
    }
    Console.WriteLine($" La suma de los inpares de   {n} a 1  es {s}");
    Console.WriteLine(" Deseas continuar? (S/N)"); resp=char.ToUpper(Console.ReadLine()[0]);
} while(resp!= 'N');
Console.WriteLine("Proceso Terminado ....");