using Ejercicio1;

Console.WriteLine("Bienvenido, al ejercicio 1!");
Console.WriteLine("Presiona cualquier tecla para continuar");
Console.ReadKey();

Console.WriteLine("##########################  Impares o Pares  ##########################");

//Variables 
List<List<TarjetasDto>> rojas = new();
List<List<TarjetasDto>> azules = new();

List<TarjetasDto> lista1 = new();
List<TarjetasDto> lista2 = new();
int numeroJuegos = 1;

const int maxRepeticiones = 100;
const int maxNumXJuego = 5;

//Logica para iniciar el juego
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();

while (numeroJuegos > 0)
{
    Console.WriteLine();
    Console.WriteLine("****************************************************************************");
    Console.WriteLine("Ingrese el número de repeticiones: ");

    do
    {
        numeroJuegos = Convert.ToInt32(Console.ReadLine());
        if (numeroJuegos < 0 || numeroJuegos > maxRepeticiones)
        {
            Console.WriteLine("!!!! La cantidad de repeticiones no puede ser menor a 0 ni mayor a 100 !!!!");
            Console.WriteLine("Intenta nuevamente");
        }

    } while (numeroJuegos < 0 || numeroJuegos > maxRepeticiones);

    if (numeroJuegos > 0)
    {
        var result = Tools.Operaciones(numeroJuegos, maxNumXJuego);
        azules.Add(result.Item1);
        rojas.Add(result.Item2);
    }

}


Console.WriteLine("!!!!!!!!!! Juego finalizado !!!!!!!!!!");
//Console.WriteLine("Presione cualquier tecla para obtener los resultados");
//Console.ReadKey();


Console.WriteLine("######################## Resultado ########################");
Console.WriteLine();

for (int i = 0; i < azules.Count; i++)
{
    var result = Tools.ObternerResultados(azules[i], rojas[i]);
    if (result.Item2 > result.Item1) Console.WriteLine(result.Item2 - result.Item1);
    else Console.WriteLine(result.Item2 - result.Item1);
}


