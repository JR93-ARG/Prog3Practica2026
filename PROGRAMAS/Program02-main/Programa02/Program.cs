
namespace Programa02;

class Program
{
    static void Main(string[] args)
    {
           // Console.WriteLine("--- BLOQUE 1: NÚMEROS ENTEROS ---");

            // Declaración de un entero
            //int edad = 28;

           // Console.WriteLine("1. TIPO ENTERO (int):");
          //  Console.WriteLine("   Para números sin decimales, como edad o cantidad.");
           // Console.WriteLine("   Valor guardado: " + edad);

           // Console.WriteLine("\nPresiona ENTER para cerrar.");
           // Console.ReadLine();

    }

    static void programa1()
    {
         Console.WriteLine("PRACTICAMOS NUMEROS ENTEROS");
    
        int num = 32;
        Console.WriteLine("Un numero entero es por ejemplo: " + num);
        Console.WriteLine("En este caso el numero " + num + " es un numero entero porque no tiene decimales.");
        Console.WriteLine("Los numeros enteros se utilizan para contar objetos, como la cantidad de personas en una sala o el número de libros en una estantería.");
        Console.WriteLine("Presiona ENTER para cerrar.");

        Console.ReadLine();

    }

    static void programa2()
    {
         Console.WriteLine("=== SUMA NUMEROS ENTEROS ===");
       
        Console.Write("Ingrese el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());
       
        Console.Write("Ingrese el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());
       
        
       
        Console.WriteLine($"La suma de {numero1} y {numero2} es: {numero1 + numero2}");
    }

    static void programa3()
    {
         static void Main(string[]args)
        {
            Console.WriteLine("CONOCIENDO LOS NUMEROS ENTEROS");
            Console.WriteLine("El numero entero es: " + int.MaxValue);
            Console.WriteLine("El numero entero es: " + int.MinValue);    
        }
    }
    
}