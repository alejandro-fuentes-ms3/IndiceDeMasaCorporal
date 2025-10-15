using imc.Model;
using System;
class Persona
{
    // Atributos
    public double Peso { get; set; }
    public double Estatura { get; set; }

    // Constructor
    public Persona(double peso, double estatura)
    {
        Peso = peso;
        Estatura = estatura;
    }

    
    


    // Método para calcular el IMC del usuario
    public double CalcularIMC()
    {
        return Peso / Math.Pow(Estatura, 2);
    }

    // Método para clasificar el IMC del usuario
    public string ClasificarIMC()
    {
        double imc = CalcularIMC();

        if (imc < 18.5)
            return "Peso bajo";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Sobrepeso";
        else if (imc < 40)
            return "Obesidad";
        else
            return "Obesidad extrema";
    }
}

class Program
{
    static void Main()
    {
        // Solicitar datos del usuario
        Console.Write("Proporciona tu peso (kg): ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Proporciona tu estatura (m): ");
        double estatura = double.Parse(Console.ReadLine());

        // Crear objeto Persona
        Persona persona = new Persona(peso, estatura);

        // Usar métodos de la clase
        double imc = persona.CalcularIMC();
        Console.WriteLine($"\nTu IMC es: {imc}");
        Console.WriteLine($"Clasificación: {persona.ClasificarIMC()}");
    }
}

