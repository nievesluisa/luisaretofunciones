using System;

class Progra
{
    static double CelsiusAFahrenheit(double celsius)
    {
        return (9.0 / 5.0) * celsius + 32;
    }
    static double FahrenheitACelsius(double fahrenheit)
    {
        return (5.0 / 9.0) * (fahrenheit - 32);
    }
    static double CelsiusAKelvin(double celsius)
    {
        return celsius + 273.15;
    }
    static void Main()
    {
        Console.WriteLine("Elije una opción:");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
        Console.WriteLine("3. Convertir de Celsius a Kelvin");
        int opcion = int.Parse(Console.ReadLine());

        double temperatura;

        switch (opcion)
        {
            case 1:
                Console.Write("Ingresa la temperatura en Celsius: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"La temperatura en Fahrenheit es: {CelsiusAFahrenheit(temperatura)}");
                break;
            case 2:
                Console.Write("Ingresa la temperatura en Fahrenheit: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"La temperatura en Celsius es: {FahrenheitACelsius(temperatura)}");
                break;
            case 3:
                Console.Write("Ingresa la temperatura en Celsius: ");
                temperatura = double.Parse(Console.ReadLine());
                Console.WriteLine($"La temperatura en Kelvin es: {CelsiusAKelvin(temperatura)}");
                break;
            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
}
