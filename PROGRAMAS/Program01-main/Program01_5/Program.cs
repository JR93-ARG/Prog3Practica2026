namespace Program01_5;

    class Program
    {
        static void Main(string[] args)
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