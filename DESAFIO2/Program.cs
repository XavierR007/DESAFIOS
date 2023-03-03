namespace PROGRAMA2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calcu = new Calculadora();

            int total = calcu.Sumar(10, 20);
            int resta = calcu.Restar(10, 5);
            int multi = calcu.Multiplicar(3, 20);
            int division = calcu.Dividir(100, 20);

            Console.WriteLine($"Los resultados son: Suma = {total}, Resta = {resta}, Multiplicacion = {multi}, Division = {division}");
        }
    }
}