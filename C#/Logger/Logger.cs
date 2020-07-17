using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    public class Logger
    {

        private static Logger instance = null;

        private Logger() { }

        public static Logger getInstance()
        {

            if(instance == null){
                instance = new Logger();
            }

            return instance;

        }

        public void imprimir(string log)
        {

            /* Si en vez de imprimirlo por consola quisiera guardarlo
             * por ejemeplo en un archivo, solo tendria que cambiar esta
             * linea y el resto del programa no se enteraria
             * */
            Console.WriteLine(log);

        }

    }
}
