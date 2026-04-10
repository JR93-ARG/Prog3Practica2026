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
        Console.WriteLine("==CONTADOR DE NUMEROS DEL 1 AL QUE ELIJAS==");
        Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(i);
            }
        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();            
    }

    static void program2()
    {
        Console.WriteLine("==MOSTRAR NUMEROS PARES HASTA EL NUMERO QUE ELIJAS==");
       Console.WriteLine("Ingrese un número:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        } 
        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();    
    }
    static void program3()
    {
        Console.WriteLine("== SUMA DE NÚMEROS HASTA QUE INGRESES 0 ==");
        double num;
        double suma = 0;

        do
        {
            Console.WriteLine("Ingrese un número (0 para terminar):");
            num = double.Parse(Console.ReadLine());

            suma = suma + num;

        } while (num != 0);

        Console.WriteLine("La suma total es: " + suma);
        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }
    static void program4()
    {
        Console.WriteLine("== TABLA DE MULTIPLICAR ==");
        Console.WriteLine("Ingrese un número y calculamos la tabla:");
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(num + " x " + i + " = " + (num * i));
        }
        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();
    }

    static void program5()
    {
        Console.WriteLine("== CONTADOR DE NÚMEROS PARES E IMPARES ==");
        int num;
        int contador = 0;

       do
        {
            Console.WriteLine("Ingrese un número (0 para terminar):");
            num = int.Parse(Console.ReadLine());

            if (num % 2 != 0)
            {
                contador++;
            }

        } while (num != 0);

        Console.WriteLine("Cantidad de números impares: " + contador);

        Console.WriteLine("\nPresiona ENTER para cerrar.");
        Console.ReadLine();

    }
}