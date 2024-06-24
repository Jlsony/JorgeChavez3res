internal class Program
{
    static Random random = new Random();

    static int LanzarDado()
    {
        return random.Next(1, 7);
    }
    private static void Main(string[] args)
    {
         Console.WriteLine("Bienvenidos al Juego de Lanzar DADOS");
            Console.WriteLine("JORGE L.CHAVEZ\n");
            bool continuarLanzando = true;

            while (continuarLanzando)
            {
                int resultado1 = LanzarDado();
                Console.WriteLine($"DADO 1 : {resultado1}");
                int resultado2 = LanzarDado();
                Console.WriteLine($"DADO 2 : {resultado2}\n");



                Console.Write("¿Quieres lanzar el dado de nuevo? (s/n): \n");
                string respuesta = Console.ReadLine();

                continuarLanzando = (respuesta.ToLower() == "s");
            }

            Console.WriteLine("¡Gracias por jugar!");
    }
}