namespace TP1
{
    public static class InputHelper
    {
        public static int LeerInt(string mensaje, int min = int.MinValue, int max = int.MaxValue)
        {
            System.Console.Write(mensaje);
            if (int.TryParse(System.Console.ReadLine(), out int valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1;
        }

        public static string LeerString(string mensaje, string respuestaDefault = "")
        {
            System.Console.Write(mensaje);
            return System.Console.ReadLine()?.Trim() ?? respuestaDefault;
        }

        public static double LeerDouble(string mensaje, double min = double.MinValue, double max = double.MaxValue)
        {
            System.Console.Write(mensaje);
            if (double.TryParse(System.Console.ReadLine(), out double valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1.0;
        }

        public static decimal LeerDecimal(string mensaje, decimal min = decimal.MinValue, decimal max = decimal.MaxValue)
        {
            System.Console.Write(mensaje);
            if (decimal.TryParse(System.Console.ReadLine(), out decimal valor) && valor >= min && valor <= max)
                return valor;
            else
                return -1;
        }
    }
}