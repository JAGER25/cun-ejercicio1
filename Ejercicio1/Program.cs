using Ejercicio1;

Console.WriteLine("Bienvenido, al ejercicio 1!");
Console.WriteLine("Presiona cualquier tecla para continuar");
Console.ReadKey();

Console.WriteLine("##########################  Impares o Pares  ##########################");

//Variables 
int numeroJuegos = 0;
List<TarjetasDto> rojas = new();
List<TarjetasDto> azules = new();


//Constantes
const string Jugador1 = "Maria";
const string Jugador2 = "Juan";

const int maxRepeticiones = 100;
const int maxNumXJuego = 5;


//Logica para iniciar el juego
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Ingrese el número de juegos: ");


do
{
    numeroJuegos = Convert.ToInt32(Console.ReadLine());
    if (numeroJuegos <= 0 || numeroJuegos > maxRepeticiones)
    {
        Console.WriteLine("!!!! La cantidad de repeticiones no puede ser menor a 0 ni mayor a 100 !!!!");
        Console.WriteLine("Intenta nuevamente");
    }
    
} while (numeroJuegos <= 0 || numeroJuegos > maxRepeticiones);

Console.WriteLine();
Console.WriteLine($"Se jugaran {numeroJuegos} repeticiones.");
Console.WriteLine();
Console.WriteLine("Presione cualquier tecla para iniciar juego, buena suerte.");
Console.WriteLine();
Console.WriteLine("Ingrese el numero ");

//Se iteran la cantidad de repeticiones 
for (int i = 1; i <= numeroJuegos; i++)
{
    Console.WriteLine($"Ingresar el número de {Jugador1}");
    azules.Add(Tools.Insertar(Jugador1,i,maxNumXJuego));
}

for (int i = 1; i <= numeroJuegos; i++)
{
    Console.WriteLine($"Ingresar el número de {Jugador2}");
    rojas.Add(Tools.Insertar(Jugador2, i, maxNumXJuego));
}

Console.WriteLine("!!!!!!!!!! Juego finalizado !!!!!!!!!!");
Console.WriteLine("Presione cualquier tecla para obtener los resultados");
Console.ReadKey();

var result = Tools.ObternerResultados(azules, rojas);

Console.WriteLine("######################## Resultado ########################");
Console.WriteLine();
Console.WriteLine($"{Jugador1} puedo haber ganado: {result.Item1}");
Console.WriteLine($"{Jugador2} puedo haber ganado: {result.Item2}");







