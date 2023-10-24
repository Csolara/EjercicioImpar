using EjercicioImpar.Servicios;

namespace EjercicioImpar
{
    class program
    {

        static void Main(string[] args)
        {

            int n1;
            MenuInterfaz mi = new MenuImplementacion();
            n1 = mi.PedirNum();

            if (n1%2==0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
        }

    }
}