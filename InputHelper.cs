using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Helper
{
    public class InputHelper
    {
        public static int LeerInt(string mensaje, int min = int.MinValue, int max = int.MaxValue)
        {
            Console.Write(mensaje);
            if (int.TryParse(Console.ReadLine(), out int valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1;
        }

        public static string LeerString(string mensaje, string respuestaDefault = "")
        {
            Console.Write(mensaje);
            return Console.ReadLine()?.Trim() ?? respuestaDefault;
        }

        public static double LeerDouble(string mensaje, double min = double.MinValue, double max = double.MaxValue)
        {
            Console.Write(mensaje);
            if (double.TryParse(Console.ReadLine(), out double valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1.0;
        }

        public static decimal LeerDecimal(string mensaje, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
            Console.Write(mensaje);
            if (decimal.TryParse(Console.ReadLine(), out decimal valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1;
        }
    }
}