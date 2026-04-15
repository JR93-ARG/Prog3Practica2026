namespace Programa10;

class Program
{
    static void Main(string[] args)
    {   
        Console.WriteLine("Ejercicio 2");
        Console.WriteLine("Inicializacion directa y foreach");

        //sintaxis simplificada de inicializacion 
        //ejercico 2.1

        string[] autos = {"renault", "Audi", "ferrari", "Volkswagen", "ford"};
        Console.WriteLine("Lista de autos usando foreach:");

        foreach (string auto in autos)
        {
            Console.WriteLine(" - " + auto);
        }
        //ejercicio 2.2
        Console.WriteLine("\nEjercicio 2.2");

        string[] plantas = {"jazmin", "asuzena", "rosa", "lirio", "menta"};
        Console.WriteLine("Lista de plantas usando foreach:");

        foreach (string planta in plantas)
        {
            Console.WriteLine(" - " + planta);
        }


        //ejercicio 2.3
        Console.WriteLine("\nEjercicio 2.3");   

        int[] edadesAlumnos = {32, 37, 19, 21, 30};
        Console.WriteLine("Edades de los alumnos usando foreach:"); 

        foreach (int edad in edadesAlumnos)
        {
            Console.WriteLine(" - " + edad);
        }


        //ejercicio 2.4
        Console.WriteLine("\nEjercicio 2.4");
        double[] precios = {19.99, 29.99, 9.99, 14.99, 24.99};
        Console.WriteLine("Precios de los productos usando foreach:");  

        foreach (double precio in precios)
        {
            Console.WriteLine(" - $" + precio);
        }

        //ejercicio 2.5
        Console.WriteLine("\nEjercicio 2.5");
        string[] ciudades = {"Tucuamn", "Salta", "Misiones", "Mendoza", "Catamarca"};
        Console.WriteLine("Lista de ciudades usando foreach:");
        foreach (string ciudad in ciudades)
        {
            Console.WriteLine(" - " + ciudad);
        }


        Console.WriteLine("\nPresiona ENTER para salir.");
        Console.ReadLine();

    }
}
