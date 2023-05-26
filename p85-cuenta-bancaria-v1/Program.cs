Console.WriteLine("\nProbando la clase CuentaBancaria:\n");
CuentaBancaria cuenta1 = new CuentaBancaria(50);
Console.WriteLine($"Saldo inicial : {cuenta1.Saldo}");
cuenta1.Deposita(20);
Console.WriteLine($"Saldo deposito: {cuenta1.Saldo}");
bool retiro = cuenta1.Retira(40);
if(retiro)
Console.WriteLine($"Saldo retiro : {cuenta1.Saldo}");
else
Console.WriteLine("No hay dinero ");