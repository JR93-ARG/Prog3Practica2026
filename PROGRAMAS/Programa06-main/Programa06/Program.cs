namespace Programa06;

class Program
{
    static void Main(string[] args)
    {
        // --- CONSTANTES DE IDENTIDAD Y REGLAS ---
           // const string NOMBRE_APP = "GameMaster Pro";
            //const string VERSION = "v1.0.2";
            //const int EDAD_MINIMA = 18;

            //Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
            //Console.WriteLine("Cargando reglas del sistema...");
            //Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");
            
            // Intento de uso con constantes (sin estructuras de control)
           // const int EDAD_CLIENTE = 20;
           // const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA; // expresión booleana

            //Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
            //Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
            //Console.WriteLine("Acceso permitido (valor bool constante): " + PUEDE_INGRESAR);

            // Mostrar constantes para reforzar concepto
            //Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
            //Console.WriteLine("Constante VERSION = " + VERSION);

            //Console.ReadLine();

            programa1();
            programa2();
            programa3();
            programa4();
            programa5();


    }
    static void programa1()
    {
        const string NOMBRE_APP = "GameMaster Pro";
        const string VERSION = "v1.0.2";
        const int EDAD_MINIMA = 18;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Prohibida la venta a menores de " + EDAD_MINIMA + " años.");

        const int EDAD_CLIENTE = 20;
        const bool PUEDE_INGRESAR = EDAD_CLIENTE >= EDAD_MINIMA;

        Console.WriteLine("\nVerificando cliente de " + EDAD_CLIENTE + " años...");
        Console.WriteLine("Edad mínima: " + EDAD_MINIMA);
        Console.WriteLine("Acceso permitido: " + PUEDE_INGRESAR);
        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);
        Console.WriteLine();
    }

    static void programa2()
    {
        const string NOMBRE_APP = "BancoSeguro App";
        const string VERSION = "v3.2.1";
        const decimal SALDO_MINIMO = 500.00m;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Saldo mínimo requerido $" + SALDO_MINIMO + ".");

        const decimal SALDO_CLIENTE = 1200.00m;
        const bool PUEDE_OPERAR = SALDO_CLIENTE >= SALDO_MINIMO;

        Console.WriteLine("\nVerificando saldo del cliente: $" + SALDO_CLIENTE);
        Console.WriteLine("Saldo mínimo requerido: $" + SALDO_MINIMO);
        Console.WriteLine("Operación permitida: " + PUEDE_OPERAR);
        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);
        Console.WriteLine();
    }

    static void programa3()
    {
         const string NOMBRE_APP = "MediControl";
        const string VERSION = "v2.0.0";
        const int TEMPERATURA_MAXIMA = 38;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Alerta si temperatura supera los " + TEMPERATURA_MAXIMA + "°C.");

        const int TEMPERATURA_PACIENTE = 36;
        const bool TIENE_FIEBRE = TEMPERATURA_PACIENTE >= TEMPERATURA_MAXIMA;

        Console.WriteLine("\nVerificando paciente con " + TEMPERATURA_PACIENTE + "°C...");
        Console.WriteLine("Temperatura máxima permitida: " + TEMPERATURA_MAXIMA + "°C");
        Console.WriteLine("Paciente con fiebre: " + TIENE_FIEBRE);
        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);
        Console.WriteLine();
    }

    static void programa4()
    {
        const string NOMBRE_APP = "EduGest";
        const string VERSION = "v1.5.0";
        const int NOTA_MINIMA = 60;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Nota mínima para aprobar es " + NOTA_MINIMA + " puntos.");

        const int NOTA_ALUMNO = 75;
        const bool APRUEBA = NOTA_ALUMNO >= NOTA_MINIMA;

        Console.WriteLine("\nVerificando alumno con nota: " + NOTA_ALUMNO);
        Console.WriteLine("Nota mínima para aprobar: " + NOTA_MINIMA);
        Console.WriteLine("Alumno aprobado: " + APRUEBA);
        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);
        Console.WriteLine();
    }

    static void programa5()
    {
        const string NOMBRE_APP = "EnvíoRápido";
        const string VERSION = "v4.1.3";
        const double PESO_MAXIMO = 20.0;

        Console.WriteLine("=== " + NOMBRE_APP + " (" + VERSION + ") ===");
        Console.WriteLine("Cargando reglas del sistema...");
        Console.WriteLine("Restricción: Peso máximo permitido por paquete " + PESO_MAXIMO + " kg.");

        const double PESO_PAQUETE = 15.5;
        const bool PESO_ACEPTADO = PESO_PAQUETE <= PESO_MAXIMO;

        Console.WriteLine("\nVerificando paquete de " + PESO_PAQUETE + " kg...");
        Console.WriteLine("Peso máximo permitido: " + PESO_MAXIMO + " kg");
        Console.WriteLine("Paquete aceptado: " + PESO_ACEPTADO);
        Console.WriteLine("Constante NOMBRE_APP = " + NOMBRE_APP);
        Console.WriteLine("Constante VERSION = " + VERSION);
        Console.WriteLine();
    }

}
