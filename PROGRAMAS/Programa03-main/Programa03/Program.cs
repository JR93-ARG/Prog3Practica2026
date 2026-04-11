using System.Runtime.CompilerServices;

namespace Programa03;

class Program
{
    static void Main()
    {
        //Console.WriteLine("--- BLOQUE 2: NÚMEROS CON DECIMALES ---");

            // Estatura (double)
           // double estatura = 1.75;
            //Console.WriteLine("2. TIPO DECIMAL COMÚN (double):");
            //Console.WriteLine("   Valor guardado: " + estatura + " metros");

            // Dinero (decimal) - Recuerda la 'm' al final
            //decimal precioProducto = 199.99m;
            //Console.WriteLine("\n3. TIPO DECIMAL FINANCIERO (decimal):");
            //Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
            //Console.WriteLine("   Valor guardado: $" + precioProducto);

           // Console.WriteLine("\nPresiona ENTER para cerrar.");
            //Console.ReadLine();

            program1();
            program2();
            program3();
            program4();
            program5();
    }

    static void program1()
    {
       double estatura = 1.75;
        Console.WriteLine("== BLOQUE 1: ESTATURA ==");
        Console.WriteLine("* TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Para guardar la estatura de una persona en metros.");
        Console.WriteLine("   Valor guardado: " + estatura + " metros");
        Console.WriteLine();          
    }

    static void program2()
    {
      double peso = 72.5;
        Console.WriteLine("== BLOQUE 2: PESO ==");
        Console.WriteLine("* TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Para guardar el peso corporal en kilogramos.");
        Console.WriteLine("   Valor guardado: " + peso + " kg");
        Console.WriteLine();   
    }
    static void program3()
    {
      decimal precioProducto = 199.99m;
        Console.WriteLine("== BLOQUE 3: PRECIO DE PRODUCTO ==");
        Console.WriteLine("* TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   ¡Obligatorio para dinero! Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + precioProducto);
        Console.WriteLine();
    }
    static void program4()
    {
      decimal sueldo = 85000.50m;
        Console.WriteLine("== BLOQUE 4: SUELDO ==");
        Console.WriteLine("* TIPO DECIMAL FINANCIERO (decimal):");
        Console.WriteLine("   Para guardar el sueldo mensual de un empleado. Usa la 'm'.");
        Console.WriteLine("   Valor guardado: $" + sueldo);
        Console.WriteLine();
    }

    static void program5()
    {
        double velocidad = 98.6;
        Console.WriteLine("== BLOQUE 5: VELOCIDAD ==");
        Console.WriteLine("* TIPO DECIMAL COMÚN (double):");
        Console.WriteLine("   Para guardar la velocidad de un vehículo en km/h.");
        Console.WriteLine("   Valor guardado: " + velocidad + " km/h");
        Console.WriteLine();

    }
}