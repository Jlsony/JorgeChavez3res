using System;

class Program
{
    static bool EsPrimo(int numero)
    {
        if (numero < 2)
            return false;

        for (int i = 2; i * i <= numero; i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int inicio, fin;

            Console.WriteLine("Ingrese el número de inicio:");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número de fin:");
            fin = Convert.ToInt32(Console.ReadLine());

             List<int> numerosPrimos = new List<int>();

              for (int num = inicio; num <= fin; num++)
            {
                if (EsPrimo(num))
                {
                    numerosPrimos.Add(num);
                    Console.WriteLine($"Es Un Número Primo: {num}");
                }
            }

           
            Console.ReadKey();
    }
    
}