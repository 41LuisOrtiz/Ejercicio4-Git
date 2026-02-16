using System;
using Ejercicio4_git;

// Nombre:Luis Felipe Ortiz López

// bus urbano
BusUrbano bus1 = new BusUrbano("ABC123", 50, 80.0, 1.5);
bus1.info();
bus1.recorrerKilometro(10);
Console.WriteLine($"Costo del viaje: {bus1.costeViaje()}\n");

// taxi
Taxi taxi1 = new Taxi("XYZ789", 4, 120.0, 5.0, 3.5);
taxi1.info();
taxi1.recorrerKilometro(15);
Console.WriteLine($"Costo del viaje: {taxi1.costeViaje()}\n");

// bici
BicicletaElectrica bici1 = new BicicletaElectrica("BIKE456", 1, 25.0, 0.5);
bici1.info();   
bici1.recorrerKilometro(5);
Console.WriteLine($"Costo del viaje: {bici1.costeViaje()}\n");