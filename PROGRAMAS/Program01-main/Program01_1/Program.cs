namespace Program01_1;

class Program
{
    static void Main(string[] args)
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
}
