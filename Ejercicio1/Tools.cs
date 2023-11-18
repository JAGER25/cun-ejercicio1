namespace Ejercicio1
{
    public static class Tools
    {
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
                foreach (var j in rojas)
                {
                    if(ValidPar(i.Numero + j.Numero))resulRojas++;
                    else resulAzules++;
                }
            }
            return (resulAzules, resulRojas);
        }

        private static bool ValidPar(int numero)
        {
            int residuo = numero % 2;
            return residuo == 0;
        }
    }
}
