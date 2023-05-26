// See https://aka.ms/new-console-template for more information
const int MAX = 100;
// double[] Nums = {10.5,6.8, 10.22, 14.33, 22.1};
double [] Nums = new double[MAX];
double suma = 0, promedio = 0;;
int op;
int n = 0;
double nb,pos;
do
{
    op = menu();
    switch (op)
    {
        case 1:
        System.Console.WriteLine("Cuantos elementos deseas?");
        n = int.Parse(Console.ReadLine());
        if (n > MAX)
        {
            System.Console.WriteLine("Excediste el limite");
        }else
        {
            for (int i = 0; i < n; i++)
            {
                do{
                    System.Console.Write($"Elemento [{i+1}]");
                    Nums[i] = double.Parse(Console.ReadLine());
                }while(Nums[i]<0 || Nums[i]>100);
                
                
            }
        }
        break;
        case 2: Mostrar(Nums, n);
            break;
        case 3:
        suma = Sumar(Nums, n);
        promedio = suma / n;
        System.Console.WriteLine($"\n El promedio es: {promedio:f2}");
        System.Console.WriteLine($"\n Los numeros mayores al promedio son: \n ");
        Prom2(Nums, n, promedio);

            break;
        case 4: 
            System.Console.WriteLine($"\nEl complemento de cada numero es: \n");
            Comp(Nums, n);
            
            break;
        case 5:
        System.Console.WriteLine("\nQue elemento buscas?");

        nb = double.Parse(Console.ReadLine());
        System.Console.WriteLine($"El numero se encuentra  {Ult(Nums, n, nb)} veces ");
            break;
    }
    
    System.Console.WriteLine("\nPresione cualquier tecla para continuar..");
    Console.ReadLine();
} while (op!=6);

int menu(){
    Console.Clear();
    System.Console.WriteLine("Leer elementos en el arreglo                  [1]");
    System.Console.WriteLine("Mostrar elementos en el arreglo               [2]");
    System.Console.WriteLine("Promedio y Calif mayores al promedio          [3]");
    System.Console.WriteLine("Mostrar complemento 100                       [4]");
    System.Console.WriteLine("Contar Calificacion                           [5]");
    System.Console.WriteLine("Salir                                         [6]");
    System.Console.WriteLine("Elige una Opción");

    int op = int.Parse(Console.ReadLine());
    return op;
}

void Mostrar(double[] a, int n){
    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"{a[i]}");
    }
}

double Sumar(double[] a, int n){
    double suma = 0;
    for (int i = 0; i < n; i++)
        suma = suma + a[i];
        return suma;

}

void Comp(double[] a, int n){
    for (int i = 0; i < n; i++)
        Console.Write($"\n {100-a[i]}");
}
void Prom2(double[] a, int n, double prom){
    for (int i = 0; i < n; i++){
        if(a[i]> prom){
        Console.Write($"\n { a[i] }");
        }
    }
        
}

double Ult(double[] a, int n, double men ){
    double suma=0;
    for (int i = 0; i < n; i++)
        if (a[i] == men)
            suma = suma +1 ;
        
    return suma;
}

double Buscar(double[] a, double nb, int n){
    int pos = 1;
    for (int i = 0; i < n; i++)
        if (a[i] == nb)
            pos = i;

    return pos;
    
}