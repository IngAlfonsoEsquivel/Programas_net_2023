// Efectua operaciones matematicas basicas con 2 numeros
float n1,n2;
char op;
Console.Clear();
Console.WriteLine("Efectua operaciones matematicas basicas con 2 numeros ");
Console.WriteLine("Dame un numero "); n1=float.Parse(Console.ReadLine());
Console.WriteLine("Dame otro numero "); n2=float.Parse(Console.ReadLine());
Console.WriteLine("(+ - * / p)?");
op=Console.ReadLine()[0];
switch(op){
    case'+':Console.WriteLine($"{n1} + {n2} = {n1+n2}"); break;
    case'-':Console.WriteLine($"{n1} - {n2} = {n1-n2}"); break;
    case'*':Console.WriteLine($"{n1} * {n2} = {n1*n2}"); break;
    case'/':Console.WriteLine($"{n1} / {n2} = {n1/n2}"); break;
    case'p':Console.WriteLine($"{n1} Pot {n2} = {Math.Pow(n1,n2)}"); break;

    default :Console.WriteLine($"Op invalida"); break;
}

