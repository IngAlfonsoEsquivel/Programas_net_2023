// See https://aka.ms/new-console-template for more information
Emp empleado01 = new Emp();
Emp empleado02 ;
empleado02 = new Emp();
Emp empleado03 = new Emp("Bob Esponja");
Emp empleado04 = new Emp("Patricio", 34);

empleado01.Nombre = "Leo";
empleado01.Edad = 33;
empleado03.Edad = 10;
empleado02.Nombre = "Maria";
empleado02.Edad = 87;
// Invocar los métdos
empleado01.ImprimirDatos();
empleado02.ImprimirDatos();
empleado03.ImprimirDatos();
empleado04.ImprimirDatos();
