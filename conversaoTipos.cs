using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace conversaoTipos
{
    public class conversaoTipos
    {
        public static void Main()
        {
            int numero = 10;
            double numeroConvertido = Convert.ToDouble(numero);
            Console.WriteLine("Número convertido para double: " + numeroConvertido);
        }
    }
}