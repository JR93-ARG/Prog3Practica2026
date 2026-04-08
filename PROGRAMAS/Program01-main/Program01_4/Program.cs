using System.ComponentModel.DataAnnotations;

namespace Program01;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("--- COBRO DE ARTICULOS ---");

            Console.Write("Ingrese el total de la venta: ");
            double totalVenta = double.Parse(Console.ReadLine());

            
            Console.Write("Ingresa metodo de pago: ");
            string metodoPago = Console.ReadLine();

            
           Console.WriteLine("\n--- DEBERA COBRAR  ---");
           
        if (metodoPago != "efectivo" || metodoPago != "EFECTIVO")
        {
            
            Console.WriteLine("El cliente debera abonar en " + metodoPago + "$" (totalVenta + (totalVenta * 0.3)));
        }
        else
        {
            Console.WriteLine  ("El cliente debera abonar en " + metodoPago + "$" + totalVenta);
        }

         
         
            

            Console.WriteLine("\nPresiona ENTER para salir.");
            Console.ReadLine();
    }
}
