namespace Program01;

class Program
{
    static void Main(string[] args)
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
}
