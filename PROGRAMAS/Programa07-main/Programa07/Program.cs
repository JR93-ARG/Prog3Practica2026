namespace Programa07;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE CÁLCULO Y CONTROL ---
          //  const decimal TASA_IVA = 0.21m; // 21% fijo
          //  const bool MODO_PRUEBA = false; // Control de seguridad
          //  const char SIMBOLO_PESO = '$';

           // Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
           // Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

          //  decimal precioBase = 1500.50m;
            //decimal impuestoCalculado = precioBase * TASA_IVA;
            //decimal total = precioBase + impuestoCalculado;

            //Console.WriteLine("\nDetalle de la compra:");
            //Console.WriteLine("Precio: " + SIMBOLO_PESO + precioBase);
            //Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
            //Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);

            //Console.ReadLine();

    }

    static void programa1()
    {
        decimal totalMesa = consumoMesa + propinaCalculada;

       const decimal TASA_IVA = 0.21m;
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE FACTURACIÓN ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioBase = 1500.50m;
        decimal impuestoCalculado = precioBase * TASA_IVA;
        decimal total = precioBase + impuestoCalculado;

        Console.WriteLine("\nDetalle de la compra:");
        Console.WriteLine("Precio base: " + SIMBOLO_PESO + precioBase);
        Console.WriteLine("IVA (" + (TASA_IVA * 100) + "%): " + SIMBOLO_PESO + impuestoCalculado);
        Console.WriteLine("TOTAL A PAGAR: " + SIMBOLO_PESO + total);
        Console.WriteLine();
    }

    static void programa2()
    {
         const decimal TASA_DESCUENTO_JUBILACION = 0.11m;
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE NÓMINA ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal sueldoBruto = 85000.00m;
        decimal descuentoJubilacion = sueldoBruto * TASA_DESCUENTO_JUBILACION;
        decimal sueldoNeto = sueldoBruto - descuentoJubilacion;

        Console.WriteLine("\nDetalle del empleado:");
        Console.WriteLine("Sueldo bruto: " + SIMBOLO_PESO + sueldoBruto);
        Console.WriteLine("Descuento jubilación (" + (TASA_DESCUENTO_JUBILACION * 100) + "%): " + SIMBOLO_PESO + descuentoJubilacion);
        Console.WriteLine("SUELDO NETO: " + SIMBOLO_PESO + sueldoNeto);
        Console.WriteLine();
    }

    static void programa3()
    {
         const decimal TASA_SEGURO = 0.05m;
        const bool MODO_PRUEBA = true;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE ENVÍOS ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal costoEnvio = 3200.00m;
        decimal seguroCalculado = costoEnvio * TASA_SEGURO;
        decimal totalEnvio = costoEnvio + seguroCalculado;

        Console.WriteLine("\nDetalle del envío:");
        Console.WriteLine("Costo base: " + SIMBOLO_PESO + costoEnvio);
        Console.WriteLine("Seguro (" + (TASA_SEGURO * 100) + "%): " + SIMBOLO_PESO + seguroCalculado);
        Console.WriteLine("TOTAL ENVÍO: " + SIMBOLO_PESO + totalEnvio);
        Console.WriteLine();
    }

    static void programa4()
    {
         const decimal TASA_RECARGO_TURISMO = 0.08m;
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE HOTEL ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal precioPorNoche = 12500.00m;
        decimal recargTurismo = precioPorNoche * TASA_RECARGO_TURISMO;
        decimal totalNoche = precioPorNoche + recargTurismo;

        Console.WriteLine("\nDetalle de la reserva:");
        Console.WriteLine("Precio por noche: " + SIMBOLO_PESO + precioPorNoche);
        Console.WriteLine("Recargo turismo (" + (TASA_RECARGO_TURISMO * 100) + "%): " + SIMBOLO_PESO + recargTurismo);
        Console.WriteLine("TOTAL POR NOCHE: " + SIMBOLO_PESO + totalNoche);
        Console.WriteLine();
    }

    static void programa5()
    {
        const decimal TASA_DESCUENTO_SOCIO = 0.15m;
        const bool MODO_PRUEBA = false;
        const char SIMBOLO_PESO = '$';

        Console.WriteLine("--- MÓDULO DE GIMNASIO ---");
        Console.WriteLine("Modo prueba activo: " + MODO_PRUEBA);

        decimal cuotaMensual = 4500.00m;
        decimal descuentoSocio = cuotaMensual * TASA_DESCUENTO_SOCIO;
        decimal cuotaFinal = cuotaMensual - descuentoSocio;

        Console.WriteLine("\nDetalle de la membresía:");
        Console.WriteLine("Cuota mensual: " + SIMBOLO_PESO + cuotaMensual);
        Console.WriteLine("Descuento socio (" + (TASA_DESCUENTO_SOCIO * 100) + "%): " + SIMBOLO_PESO + descuentoSocio);
        Console.WriteLine("CUOTA FINAL: " + SIMBOLO_PESO + cuotaFinal);
        Console.WriteLine();
    }


}
