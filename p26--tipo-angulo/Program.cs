Console.Clear();
Console.WriteLine("Muestra el tipo de angulo (0..360)\n");
Console.Write("Dame un angulo ? ");
int angulo = int.Parse(Console.ReadLine());
if(angulo <0 || angulo >360){
    Console.Write("Pongase Listo mijo ");
}
else{
    if(angulo==0)
    Console.WriteLine("\nEs Nulo");
    if(angulo!=0 && angulo<90)
    Console.WriteLine("\nEs agudo");
    if(angulo==90)
    Console.WriteLine("\nEs recto");
    if(angulo>90 && angulo<180)
    Console.WriteLine("\nEs obtuso");
    if(angulo==180)
    Console.WriteLine("\nEs llano");
    if(angulo>180 && angulo<360)
    Console.WriteLine("\nEs concavo");
    if(angulo==360)
    Console.WriteLine("\nEs completo");
}