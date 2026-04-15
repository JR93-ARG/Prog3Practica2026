Console.WriteLine("ejercicio De Logica 1");

string[] nombres = new string[20];
int [] edades = new int[20];
string[] ingresaron = new string[20];
int ingresaronContador = 0;

for(int i = 0 ; i < nombres.Length ; i ++)
{   
    int orden = i + 1;

    Console.WriteLine(orden + ". Ingrese su nombre");
    nombres[i] = Console.ReadLine();

    Console.WriteLine(orden + ". " + nombres[i] + " Ingrese su edad");
    edades[i] = int.Parse(Console.ReadLine());

}
// for para llenar los arrays
Console.WriteLine("==> DATOS COMPLETOS PRESIONE UNA TECLA PARA CONTINUAR <==");
Console.ReadLine();

for(int i = 0 ; i < nombres.Length ; i ++)
  {
    int orden = i + 1;
  if (edades[i] >= 30)
   {
     ingresaron[ingresaronContador++] = nombres[i];   //aqui se llena el array ingresaron
     Console.WriteLine(orden + ". " + nombres[i] + "- Puede Ingresar");
    }
    else
    {
        Console.WriteLine(orden + ". " + nombres[i]+ "- No puede ingresar, pa la casa");
    }

}
// ultimo for
Console.WriteLine("==> ANALISIS TERMINDO PRESIONE UNA TECLA PARA CONTINUAR <==");
Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Personas que ingresaron:");
for (int i = 0; i < ingresaronContador; i++)
{
    int orden = i + 1;
    Console.WriteLine(orden + ". " + ingresaron[i]);
}    
Console.WriteLine("presiona Enter para salir");
Console.ReadLine();