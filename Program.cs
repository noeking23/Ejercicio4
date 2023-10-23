using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de números a comparar:");
        int n = int.Parse(Console.ReadLine());

        int mayor = int.MinValue; // Inicializamos la variable mayor con el valor mínimo

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Ingrese el número {i}: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > mayor)
            {
                mayor = numero; // Actualizamos el valor del mayor si encontramos un número más grande
            }
        }

        Console.WriteLine($"El número mayor es: {mayor}");
    }
}
