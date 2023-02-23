// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Muestra la estacion del ano que corresponde al numero 1,2,3,4 ");
Console.Write("Dame un numero entre 1 y 4?      ");
int n = int.Parse(Console.ReadLine());
if(n>0 && n<5 ){
    if(n==1) Console.WriteLine("Primavera\n");
    if(n==2) Console.WriteLine("Verano\n");
    if(n==3) Console.WriteLine("Otoño\n");
    if(n==4) Console.WriteLine("Invierno\n");

}
else{
    Console.WriteLine("En que planeta vives");
}

