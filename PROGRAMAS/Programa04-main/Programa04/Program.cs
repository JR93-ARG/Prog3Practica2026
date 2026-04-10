namespace Programa04;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("--- BLOQUE 3: TEXTO Y CARACTERES ---");

            // Cadena de texto (string) - Comillas dobles ""
            //string nombre = "Ana López";
           // Console.WriteLine("4. TIPO TEXTO (string):");
           // Console.WriteLine("   Valor guardado: " + nombre);

            // Carácter único (char) - Comillas simples ''
            //char inicialNombre = 'A';
            //Console.WriteLine("\n5. TIPO CARÁCTER (char):");
           // Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");

           // Console.WriteLine("\nPresiona ENTER para cerrar.");
            //Console.ReadLine();

            programa1();
           
            programa2();
            programa3();
            programa4();
            programa5();

    }

    static void programa1()
    {
        Console.WriteLine("== INGRESAR Y MOSTRAR NÚMEROS ==");
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        
        Console.WriteLine("El orden de ingreso fue:");
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("* " + numeros[i]);
        }

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
     }

    static void programa2()
    {
        Console.WriteLine("== SUMAR NUMEROS DEL 1 AL 5 ==");
        double[] numeros = new double[5];
        double suma = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            suma = suma + numeros[i];
        }

        Console.WriteLine("La suma es: " + suma);

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

    static void programa3()
    {
        Console.WriteLine("== ENCONTRAREMOS EL NÚMERO MAYOR ==");   
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        int mayor = numeros[0];

        for (int i = 1; i < 5; i++)
        {
            if (numeros[i] > mayor)
            {
                mayor = numeros[i];
            }
        }

        Console.WriteLine("El número mayor es: " + mayor);

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

    static void programa4()
    {
        Console.WriteLine("== CONTAR NÚMEROS PARES ==");

        int[] numeros = new int[5];
        int contador = 0;

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 5; i++)
        {
            if (numeros[i] % 2 == 0)
            {
                contador++;
            }
        }

        Console.WriteLine("Cantidad de números pares: " + contador);

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

    static void programa5()
    {
        Console.WriteLine("== MOSTRAR NÚMEROS EN ORDEN INVERSO ==");
       
        int[] numeros = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Ingrese un número:");
            numeros[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El orden inverso de ingreso fue:");

        for (int i = 4; i >= 0; i--)
        {
            
            Console.WriteLine("* " + numeros[i]);
        }

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
}
}