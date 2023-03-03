namespace DESAFIO4
{
    internal class Program
    {
        static string nombre = "";
        static string contrasena = "" ;
        static void Main(string[] args)
   
        {
            Registrarse();
            Iniciar_Sesion();
        }
        public static void Registrarse()
        {
            Console.WriteLine("Ingrese nombre de su Usuario: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su Contrasena: ");
            contrasena = Console.ReadLine();

        }
        public static void Iniciar_Sesion()
        {
            Console.WriteLine("Login ingrese nombre de su Ususario: ");
            string nombre_usuario = Console.ReadLine();

            Console.WriteLine("Login inggrese su contrasena: ");
            string contrasena_usuario = Console.ReadLine();

            if (nombre.ToLower().Equals(nombre_usuario))
            {
                if (contrasena.Equals(contrasena_usuario))
                {
                    Console.WriteLine("Bienvenido {0}", nombre_usuario);
                }
                else
                {
                    Console.WriteLine("Contrasena incorrecta");
                }
            }
            else
            {
                Console.WriteLine("El usuario o la contrasena que ingreso son incorrectos, Por favor intente de nuevo");
            }
        }
    }
}