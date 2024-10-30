namespace Metodos_funciones_Normal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje("Mensaje Desde el metodo...1");
            MostrarMensaje("Mensaje Desde el metodo...2");

            Sumar(2, 5);
        }

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        static void Sumar(int primerNumero, int segundoNumnero)
        {
            int total = primerNumero + segundoNumnero;
            MostrarMensaje($"El resultado de la suma de {primerNumero} Y {segundoNumnero"total.ToString());
        }
    }
}
