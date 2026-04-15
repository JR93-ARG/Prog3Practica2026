
using Microsoft.VisualBasic;

namespace Programa11;

class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Ejercicio 3 Uso  de .length y for");

    //ejercicio 3.1
    int[] unidades = { 25 , 35 , 45 , 55 , 65 };
    int cantidadUnidades = unidades.Length;
    Console.WriteLine("el arreglo unidades tiene " + cantidadUnidades + " elementos");  

    for (int i = 0; i < unidades.Length; i++)
    {
        Console.WriteLine("el elemento en la posición " + i + " es: " + unidades[i]);       

    }

    Console.WriteLine("Fin, presiona enter para salir");
    Console.ReadLine();

    //ejercicio 3.2
    string[] nombres = { "Jose" , "Ana" , "Lautaro" , "Sofia" , "Eliana" };
    int cantidadNombres = nombres.Length;
    Console.WriteLine("el arreglo nombres tiene " + cantidadNombres + " elementos");    

    for (int i = 0; i < nombres.Length; i++)
    {
        Console.WriteLine("el elemento en la posición " + i + " es: " + nombres[i]);       

    }   


    //ejercicio 3.3
    int[] edades = { 32 , 37 , 19 , 21 , 30 };
    int cantidadEdades = edades.Length;
    Console.WriteLine("el arreglo edades tiene " + cantidadEdades + " elementos");

    for (int i = 0; i < edades.Length; i++)
    {
        Console.WriteLine("el elemento en la posición " + i + " es: " + edades[i]);
    }

    //ejercico  3.4
    double[] precios = { 10.5 , 20.75 , 30.25 , 40.0 , 50.5 };
    int cantidadPrecios = precios.Length;
    Console.WriteLine("el arreglo precios tiene " + cantidadPrecios + " elementos");    
    for (int i = 0; i < precios.Length; i++)
    {
        Console.WriteLine("el elemento en la posición " + i + " es: " + precios[i]);
    }


    //ejercicio 3.5
    bool[] respuestas = { false , true , true , false , true };
    int cantidadRespuestas = respuestas.Length;
    Console.WriteLine("el arreglo respuestas tiene " + cantidadRespuestas + " elementos");    
    for (int i = 0; i < respuestas.Length; i++)
    {
        Console.WriteLine("el elemento en la posición " + i + " es: " + respuestas[i]);
    }
    


        Console.WriteLine("Fin, presiona enter para salir");
        Console.ReadLine();




















}
}
