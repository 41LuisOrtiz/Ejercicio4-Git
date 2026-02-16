using System;
namespace Ejercicio4_git;
public class BicicletaElectrica : Veiculo
{
    private double costeEnergiaPorKm;
    // constructor
    public BicicletaElectrica(string placa, int capacidad_de_pasajeros, double velocidad_maxima, double costeEnergiaPorKm) : base(placa, capacidad_de_pasajeros, velocidad_maxima)
    {
        this.costeEnergiaPorKm = costeEnergiaPorKm;
    }
    // metodos
    public override double costeViaje()
    {
        return getKilometrosRecorridos() * costeEnergiaPorKm;
    }   
    public override void info()
    {
        Console.WriteLine($"Bicicleta Electrica - \nPlaca: {getPlaca()}\nCapacidad: {getCapacidadDePasajeros()}\nVelocidad Maxima: {getVelocidadMaxima()}\nKilometros recorridos: {getKilometrosRecorridos()}\nCoste de Energia por Km: {costeEnergiaPorKm}");
    }
    public override void recorrerKilometro(double kilometros)
    {
        setKilometrosRecorridos(getKilometrosRecorridos() + kilometros);
        Console.WriteLine($"La bicicleta electrica ha recorrido {getKilometrosRecorridos()} kilometros.");
    }
}