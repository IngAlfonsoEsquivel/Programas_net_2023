﻿// Calcula el promedio de tres números usando una función
float promedio(float n1, float n2, float n3, float n4) {
float suma;
suma = n1 + n2 + n3 + n4;
return suma/4;
}
string[] nums;
float n1, n2, n3, n4, prom;
Console.Clear();
Console.Write("Dame cuatro números separados por espacio : ");
nums = Console.ReadLine().Split();
n1 = float.Parse(nums[0]); n2 = float.Parse(nums[1]); n3 = float.Parse(nums[2]); n4=float.Parse(nums[3]);
prom = promedio(n1, n2, n3, n4);
Console.WriteLine($"\nEl promedio es {prom:f2}");