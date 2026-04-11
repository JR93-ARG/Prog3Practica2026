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
         string nombre = "Ana López";
        Console.WriteLine("== BLOQUE 1: NOMBRE COMPLETO ==");
        Console.WriteLine("* TIPO TEXTO (string):");
        Console.WriteLine("   Para guardar el nombre completo de una persona. Usa comillas dobles.");
        Console.WriteLine("   Valor guardado: " + nombre);
        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

       
     

    static void programa2()
    {
         char inicialNombre = 'A';
        Console.WriteLine("== BLOQUE 2: INICIAL DEL NOMBRE ==");
        Console.WriteLine("* TIPO CARÁCTER (char):");
        Console.WriteLine("   Para guardar una sola letra. Usa comillas simples.");
        Console.WriteLine("   Valor guardado: '" + inicialNombre + "'");
        
        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

    static void programa3()
    {
        
        string direccion = "Av. Corrientes 1234, Buenos Aires";
        Console.WriteLine("== BLOQUE 3: DIRECCIÓN ==");
        Console.WriteLine("* TIPO TEXTO (string):");
        Console.WriteLine("   Para guardar una dirección completa. Usa comillas dobles.");
        Console.WriteLine("   Valor guardado: " + direccion);
        
        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

    static void programa4()
    {
       char letraCalificacion = 'B';
        Console.WriteLine("== BLOQUE 4: LETRA DE CALIFICACIÓN ==");
        Console.WriteLine("* TIPO CARÁCTER (char):");
        Console.WriteLine("   Para guardar la calificación de un alumno con una sola letra.");
        Console.WriteLine("   Valor guardado: '" + letraCalificacion + "'");
        Console.WriteLine();
        Console.WriteLine("Cantidad de números pares: " + contador);

        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
    }

    static void programa5()
    {
        string correo = "ana.lopez@gmail.com";
        Console.WriteLine("== BLOQUE 5: CORREO ELECTRÓNICO ==");
        Console.WriteLine("* TIPO TEXTO (string):");
        Console.WriteLine("   Para guardar una dirección de correo electrónico. Usa comillas dobles.");
        Console.WriteLine("   Valor guardado: " + correo);
        
        Console.WriteLine("Presiona ENTER para salir.");
        Console.ReadLine();
}
}