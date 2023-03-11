using System;
using System.Threading;

class Program
{
    static void saludo(string nom_saludo)
    {
        Console.WriteLine($"Hola {nom_saludo}, gusto de saludarte");
    }

    static void desglose(string nom)
    {
        string nuevo = nom.ToUpper();
        int longitud = nom.Length;
        string r = "";

        for (int c = 0; c < nuevo.Length; c++)
        {
            Console.SetCursorPosition(10 + c, 10);
            Console.Write(nuevo[c] + " ");
            r = r + nuevo[c].ToString().ToLower();
            Thread.Sleep(1000);
        }
        if (nuevo.Equals(r);
            

        Console.WriteLine("minuscula=" + r);
    }

    static int calculo(int edad)
    {
        int añoNac = 2023 - edad;
        return añoNac;
    }

    static void Main()
    {
        string nombre;
        int edad;
        int año;

        Console.WriteLine("¿Cuál es tu nombre?");
        nombre = Console.ReadLine();
        saludo(nombre);

        Console.WriteLine("¿Cuántos años tienes?");
        edad = Convert.ToInt32(Console.ReadLine());
        año = calculo(edad);
        Console.WriteLine($"Naciste en el año: {año}");
        Console.WriteLine($"¡Wow, {nombre}, esa edad de {edad} es genial!");
    }
}
