namespace Programa08;

class Program
{
    static void Main(string[] args)
    {
        // inferencia de tipo con var (sin estructuras de control)
        var x = 10;                       // int
        var y = 3.14;                     // double
        var mensaje = "Hola sin control"; // string

        // colecciones sin bucles explícitos
        var lista = new System.Collections.Generic.List<int> { 1, 2, 3 };
        var suma = lista[0] + lista[1] + lista[2];

        Console.WriteLine($"x = {x}, y = {y}, mensaje = {mensaje}");
        Console.WriteLine($"suma de lista = {suma}");

        // cálculo sin estructura de control
        var total = x + (int)y + suma;
        Console.WriteLine($"total = {total}");
    }


    static void programa1()
    {
        var x = 10;
        var y = 3.14;
        var mensaje = "Hola sin control";

        var lista = new System.Collections.Generic.List<int> { 1, 2, 3 };
        var suma = lista[0] + lista[1] + lista[2];

        Console.WriteLine("--- MÓDULO: INFERENCIA BÁSICA ---");
        Console.WriteLine($"x = {x}, y = {y}, mensaje = {mensaje}");
        Console.WriteLine($"suma de lista = {suma}");

        var total = x + (int)y + suma;
        Console.WriteLine($"total = {total}");
        Console.WriteLine();
    }

    static void programa2()
    {
        var nombre = "Notebook";
        var precio = 1299.99;
        var disponible = true;

        var precios = new System.Collections.Generic.List<double> { 999.99, 1299.99, 1599.99 };
        var promedioPrecios = (precios[0] + precios[1] + precios[2]) / 3;

        Console.WriteLine("--- MÓDULO: INFERENCIA PRODUCTO ---");
        Console.WriteLine($"nombre = {nombre}, precio = {precio}, disponible = {disponible}");
        Console.WriteLine($"promedio de precios = {promedioPrecios}");

        var precioConIva = precio * 1.21;
        Console.WriteLine($"precio con IVA = {precioConIva}");
        Console.WriteLine();
    }

    static void programa3()
    {
        var alumno = "Carlos Pérez";
        var promedio = 8.75;
        var aprobado = true;

        var notas = new System.Collections.Generic.List<int> { 7, 9, 10 };
        var sumaNotas = notas[0] + notas[1] + notas[2];

        Console.WriteLine("--- MÓDULO: INFERENCIA ESTUDIANTE ---");
        Console.WriteLine($"alumno = {alumno}, promedio = {promedio}, aprobado = {aprobado}");
        Console.WriteLine($"suma de notas = {sumaNotas}");

        var notaFinal = sumaNotas / notas.Count;
        Console.WriteLine($"nota final = {notaFinal}");
        Console.WriteLine();
    }

    static void programa4()
    {
        var ciudad = "Buenos Aires";
        var temperatura = 24.5;
        var lluvioso = false;

        var temperaturas = new System.Collections.Generic.List<double> { 22.0, 24.5, 26.0 };
        var sumaTemperaturas = temperaturas[0] + temperaturas[1] + temperaturas[2];

        Console.WriteLine("--- MÓDULO: INFERENCIA CLIMA ---");
        Console.WriteLine($"ciudad = {ciudad}, temperatura = {temperatura}, lluvioso = {lluvioso}");
        Console.WriteLine($"suma de temperaturas = {sumaTemperaturas}");

        var promedioTemp = sumaTemperaturas / temperaturas.Count;
        Console.WriteLine($"promedio de temperatura = {promedioTemp}");
        Console.WriteLine();
    }

    static void programa5()
    {
        var deporte = "Fútbol";
        var jugadores = 22;
        var enJuego = true;

        var goles = new System.Collections.Generic.List<int> { 2, 1, 3 };
        var totalGoles = goles[0] + goles[1] + goles[2];

        Console.WriteLine("--- MÓDULO: INFERENCIA CANCHA ---");
        Console.WriteLine($"deporte = {deporte}, jugadores = {jugadores}, enJuego = {enJuego}");
        Console.WriteLine($"total de goles = {totalGoles}");

        var golesPromedio = jugadores + totalGoles;
        Console.WriteLine($"jugadores + goles = {golesPromedio}");
        Console.WriteLine();
    }
}
