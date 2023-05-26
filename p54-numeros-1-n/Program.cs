// See https://aka.ms/new-console-template for more information
    
    int n,i,p;
    char resp;
    do{
        Console.Clear();
        Console.WriteLine("Numeros de 1 a n con paso de p \n");
        Console.Write("Hasta donde ? "); n=int.Parse(Console.ReadLine());
        Console.Write("Paso ? "); p=int.Parse(Console.ReadLine());
        for( i=1; i<=n; i+=p) {
        Console.Write($"{i} ");
        }
        Console.WriteLine(" Deseas continuar (S/N) ");
        resp= char.ToUpper(Console.ReadLine()[0]);
    }while (resp!='N');
    Console.WriteLine("Proceso terminado...");