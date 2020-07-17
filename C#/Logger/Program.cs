using System;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {

            // Obtengo el objeto Logger
            Logger logger = Logger.getInstance();

            // Hago una cuenta
            var num = 5;
            num = num * 43;
            
            // Log del resultado
            logger.imprimir(num.ToString());

            // Mantengo la consola en espera para poder leer el resultado
            Console.ReadLine();

        }
    }
}
