
double cal1,cal2,cal3,cal4,cal5;
Console.Write("Calcular el promedio de 5 evaluaciones \n"); 

Console.Write("Calificacion 1:"); cal1 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 2:"); cal2 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 3:"); cal3 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 4:"); cal4 = double.Parse(Console.ReadLine());
Console.Write("Calificacion 5:"); cal5 = double.Parse(Console.ReadLine());
double promedio = (cal1+cal2+cal3+cal4+cal5)/5;
if (promedio>0 && promedio <=6){
    Console.Write("Quedas Reprobado"); 
}else if(promedio>6 && promedio<=7){
    Console.Write("Pasas de panzazo"); 
}else if(promedio>7 && promedio<=8){
    Console.Write("Muy bien, puedes mejorar");
}else if(promedio>8 && promedio<=9){
    Console.Write("Excelente sigue asi");
}else if(promedio>9 && promedio<=10){
    Console.Write("Perfecto tu esfuerzo valió la pena");
}