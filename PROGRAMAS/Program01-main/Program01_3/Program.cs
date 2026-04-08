namespace Program01_03;

class Program
{
    static void Main(string[] args)
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
}
