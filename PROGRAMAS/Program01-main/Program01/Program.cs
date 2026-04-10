namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       //Console.WriteLine("--- SISTEMA DE REGISTRO DE USUARIO ---");
//
            // 1. Entrada de Texto (Simple)
            //Console.Write("Por favor, ingresa tu nombre: ");
            //string nombre = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            //Console.Write("Ingresa tu edad: ");
            //string edadTexto = Console.ReadLine();
           // int edad = int.Parse(edadTexto); // Convertimos el texto a número entero

            // 3. Entrada de Decimales (Precios o Medidas)
            //Console.Write("Ingresa tu estatura (ejemplo: 1,75): ");
            //double estatura = double.Parse(Console.ReadLine()); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            //Console.WriteLine("\n--- PERFIL CREADO ---");
           // Console.WriteLine("Nombre: " + nombre);
           // Console.WriteLine("Edad el próximo año: " + (edad + 1)); // Operación matemática
            //Console.WriteLine("Estatura: " + estatura + " metros");

          //  Console.WriteLine("\nPresiona ENTER para salir.");
            //Console.ReadLine();
    }

    static void programa1()
    {
        Console.WriteLine("--- APTO FISICO ---");

            // 1. Entrada de Texto
            Console.Write("Por favor, ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Ingresa se sos amateur (s/n): ");
            string esAmateur = Console.ReadLine(); // Conversión directa en una línea

            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- PERFIL CREADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Es amateur: " + esAmateur); // Mostrar directamente sin conversión

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
    
    static void programa2 ()
    {
        Console.WriteLine("--- SISTEMA DE CONTROL DE USUARIO ---");

            // 1. Entrada de Texto (Simple)
            Console.Write("Por favor, ingresa tu apellido: ");
            string nombre = Console.ReadLine();

            // 2. Entrada de Números (Requiere Conversión)
            Console.Write("Ingresa tu area: ");
            string area = Console.ReadLine();
           

            // 3. Entrada de Decimales (Precios o Medidas)
            Console.Write("Ingresa tu legajo (ejemplo: 12345): ");
            int legajo = int.Parse(Console.ReadLine()); 

            DateTime actual = DateTime.Now;
            
             
            // 4. Mostrar los resultados procesados
            Console.WriteLine("\n--- INGRESO REGISTRADO ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Área: " + area);
            Console.WriteLine("Legajo: " + legajo);
            Console.WriteLine("Asistencia del día: " + actual.ToString("dd/MM/yyyy HH:mm:ss"));

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }

    static void programa3 ()
    {
        Console.WriteLine("--- SISTEMA DE CONTROL JUBILATORIO ---");

            Console.Write("Por favor, ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingresa tu fecha de nacimiento (ejemplo: 1980): ");
             int añoNacimiento = int.Parse(Console.ReadLine());

            Console.Write("Ingresa tus años de inicio de actividades (ejemplo: 2000): ");
            int añoInicActividad = int.Parse(Console.ReadLine());

                      

            Console.WriteLine("\n--- INFORMACIÓN REGISTRADA ---");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Edad este año: " + (2026  - añoNacimiento)); 
            Console.WriteLine("Años de inicio de actividades: " + añoInicActividad);
            if (añoInicActividad <= 1996 && añoNacimiento <= 1960)
             {
                Console.WriteLine("¡Felicidades! Ya estás jubilado.");
            }
             else
             {
                Console.WriteLine("Aún no estás jubilado.");
             }
            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }

    static void programa4 ()
    {
        Console.WriteLine("--- COBRO DE ARTICULOS ---");

            Console.Write("Ingrese el total de la venta: ");
            double totalVenta = double.Parse(Console.ReadLine());

            
            Console.Write("Ingresa metodo de pago: ");
            string metodoPago = Console.ReadLine();

            
           Console.WriteLine("\n--- DEBERA COBRAR  ---");
           
        if (metodoPago != "efectivo" && metodoPago != "EFECTIVO")
        {
            
            Console.WriteLine("El cliente debera abonar en " + metodoPago + " $" + (totalVenta + (totalVenta * 0.3)));
        }
        else
        {
            Console.WriteLine  ("El cliente debera abonar en " + metodoPago + " $" + totalVenta);
        }                  

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }

    static void programa5()
    {
         Console.WriteLine("--- CRONOMETRO ---");

            Console.WriteLine("Presiona ENTER para iniciar el cronometro.");
            Console.ReadLine();

            var startTime = DateTime.Now;

            Console.WriteLine("Cronometro iniciado. Presiona ENTER para detenerlo.");
            Console.ReadLine();

            var endTime = DateTime.Now;


            var duration = endTime - startTime;

            Console.WriteLine("Tiempo transcurrido: " + duration + " .");

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine(); 
    }
}
