using System;
namespace Ejercicio4_git;
public abstract class Veiculo
{
    // caracteristicas del veiculo
    private string placa; 
    private int capacidad_de_pasajeros; 
    private double velocidad_maxima;
    private double kilometros_recorridos;

    // getters y setters publicos
    public string getPlaca() { return placa; }
    public int getCapacidadDePasajeros() { return capacidad_de_pasajeros; }
    public double getVelocidadMaxima() { return velocidad_maxima; }
    public double getKilometrosRecorridos() { return kilometros_recorridos; }

    public void setPlaca(string placa) { this.placa = placa; }
    public void setCapacidadDePasajeros(int capacidad_de_pasajeros) { this.capacidad_de_pasajeros = capacidad_de_pasajeros; }
    public void setVelocidadMaxima(double velocidad_maxima) { this.velocidad_maxima = velocidad_maxima; }
    public void setKilometrosRecorridos(double kilometros_recorridos) { this.kilometros_recorridos = kilometros_recorridos; }
    
    // constructor
    public Veiculo(string placa, int capacidad_de_pasajeros, double velocidad_maxima)
    {
        this.placa = placa;
        this.capacidad_de_pasajeros = capacidad_de_pasajeros;
        this.velocidad_maxima = velocidad_maxima;
        this.kilometros_recorridos = 0;
    }

    // metodos
    public abstract double costeViaje();
    public abstract void info();
    public abstract void recorrerKilometro(double kilometros);
    
}