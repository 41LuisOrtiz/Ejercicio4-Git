using System;
namespace Ejercicio4_git;
public class Taxi : Veiculo
{
    private double tarifaBase;
    private double tarifaPorKm;

    public Taxi(string placa, int capacidad_de_pasajeros, double velocidad_maxima, double tarifaBase, double tarifaPorKm) : base(placa, capacidad_de_pasajeros, velocidad_maxima)
    {
        this.tarifaBase = tarifaBase;
        this.tarifaPorKm = tarifaPorKm;
    }

    public override double costeViaje()
    {
        return tarifaBase + (getKilometrosRecorridos() * tarifaPorKm);
    }

    public override void info()
    {
        Console.WriteLine($"Taxi - \nPlaca: {getPlaca()}\nCapacidad: {getCapacidadDePasajeros()}\nVelocidad Maxima: {getVelocidadMaxima()}\nKilometros recorridos: {getKilometrosRecorridos()}\nTarifa Base: {tarifaBase}\nTarifa por Km: {tarifaPorKm}");
    }

    public override void recorrerKilometro(double kilometros)
    {
        setKilometrosRecorridos(getKilometrosRecorridos() + kilometros);
        Console.WriteLine($"El taxi ha recorrido {getKilometrosRecorridos()} kilometros.");
    }
}