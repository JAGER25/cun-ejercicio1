namespace Ejercicio1
{
    public static class Tools
    {
        public static (List<TarjetasDto>, List<TarjetasDto>) Operaciones(int numeroJuegos, int maxNumXJuego)
        {
            List<TarjetasDto> lista1 = new();
            List<TarjetasDto> lista2 = new();

            //Constantes
            const string Jugador1 = "Maria";
            const string Jugador2 = "Juan";

            Console.WriteLine();

            //Se iteran la cantidad de repeticiones 
            for (int i = 1; i <= numeroJuegos; i++)
            {
                Console.WriteLine($"Ingresar el número de {Jugador1}");

                lista1.Add(Tools.Insertar(Jugador1, i, maxNumXJuego));
            }

            for (int i = 1; i <= numeroJuegos; i++)
            {
                Console.WriteLine($"Ingresar el número de {Jugador2}");
                lista2.Add(Tools.Insertar(Jugador2, i, maxNumXJuego));
            }

            return (lista1, lista2);

        }
        public static TarjetasDto Insertar(string jugador, int i, int maxNumXJuego)
        {
            int numeroSeleccionado = 0;
            Console.WriteLine($"Turno {i}.");
            Console.WriteLine();
            do
            {
                numeroSeleccionado = Convert.ToInt32(Console.ReadLine());
                if (numeroSeleccionado < 0 || numeroSeleccionado > maxNumXJuego)
                {
                    Console.WriteLine($"!!!! El número no puede ser mayor a {maxNumXJuego} ni menor a 0!!!!");
                    Console.WriteLine("Intenta nuevamente");
                }

            } while (numeroSeleccionado < 0 || numeroSeleccionado > maxNumXJuego);

            return new TarjetasDto() { Position = i, Numero = numeroSeleccionado };
        }

        public static (int, int) ObternerResultados(List<TarjetasDto> azules, List<TarjetasDto> rojas)
        {
            int resulAzules = 0, resulRojas = 0;

            foreach (var i in azules)
            {
                if ((i.Numero & 1) == 1) resulAzules++;
            }

            foreach (var j in rojas)
            {
                if ((j.Numero & 1) == 0) resulRojas++;
            }
            return (resulAzules, resulRojas);
        }

    }
}
