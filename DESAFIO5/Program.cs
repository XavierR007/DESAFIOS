namespace DESAFIO5
{
    internal class Program
    {
        static int puntaje_record = 0;
        static string jugador_record = "";
        static void Main(string[] args)
        {
            puntajes(20, "xavier");
            puntajes(40, "Christian");
            puntajes(60, "Marco");
            puntajes(45, "Antonio");
            puntajes(100, "Solis");
            puntajes(99, "Buki");
        }

        public static void puntajes(int puntaje_obtenido, string nombre_jugador)
        {
            if (puntaje_obtenido > puntaje_record)
            {
                puntaje_record = puntaje_obtenido;
                jugador_record = nombre_jugador;

                Console.WriteLine("La nueva puntuacion mas alta es: {0}", puntaje_record);
                Console.WriteLine("La nueva puntuacion fue obtenida por: {0}", jugador_record);
            }
            else
            {
                Console.WriteLine("La puntuacion mas alta de: {0}, no se ah podido superar y " + "aun esta en manos de: {1}", puntaje_record, jugador_record);
            }
        }
    }
}