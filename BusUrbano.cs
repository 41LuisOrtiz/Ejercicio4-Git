using System;
namespace Ejercicio4_git;

public class BusUrbano : Veiculo
{
    // caracteristicas del bus urbano
    private double tarifaPorKm { get; set; }
    
    // constructor
    public BusUrbano(string placa, int capacidad_de_pasajeros, double velocidad_maxima, double tarifaPorKm) : base(placa, capacidad_de_pasajeros, velocidad_maxima)
    {
        this.tarifaPorKm = tarifaPorKm;
    }

    // metodos
    public override double costeViaje()
    {
        return getKilometrosRecorridos() * tarifaPorKm;
    }

    public override void info()
    {
        Console.WriteLine($"Bus Urbano - \nPlaca: {getPlaca()}\nCapacidad: {getCapacidadDePasajeros()}\nVelocidad Maxima: {getVelocidadMaxima()}\nKilometros recorridos: {getKilometrosRecorridos()}\nTarifa por Km: {tarifaPorKm}");
    }

    public override void recorrerKilometro(double kilometros)
    {
        setKilometrosRecorridos(getKilometrosRecorridos() + kilometros);
        Console.WriteLine($"El bus urbano ha recorrido {getKilometrosRecorridos()} kilometros.");
    }
}