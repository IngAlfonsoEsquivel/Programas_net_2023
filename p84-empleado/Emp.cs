public class Emp{
    public string Nombre { get; set;}
    public int Edad {get; set;}

    public Emp (){}
    public Emp(string nombre)=> Nombre=nombre;
    public Emp(string nombre, int edad) => (Nombre,Edad) = (nombre,edad);


public void ImprimirDatos(){
    Console.WriteLine($"Nombre: {Nombre}");
    Console.WriteLine($"Edad: {Edad}");
}
}