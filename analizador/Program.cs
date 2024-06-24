using System;

class Progr
{
    static int ContarPalabras(string texto)
    {
        string[] palabras = texto.Split(' ');
        return palabras.Length;
    }

    static int ContarVocales(string texto)
    {
        int contador = 0;
        foreach (char letra in texto.ToLower())
        {
            if ("aeiou".Contains(letra))
                contador++;
        }
        return contador;
    }

    static string InvertirTexto(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }

    static void Main()
    {
        Console.Write("Ingresa un texto: ");
        string texto = Console.ReadLine();

        Console.WriteLine($"Número de palabras: {ContarPalabras(texto)}");
        Console.WriteLine($"Número de vocales: {ContarVocales(texto)}");
        Console.WriteLine($"Texto invertido: {InvertirTexto(texto)}");
    }
}
