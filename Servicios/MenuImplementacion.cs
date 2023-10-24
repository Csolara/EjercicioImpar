using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioImpar.Servicios
{
    class MenuImplementacion : MenuInterfaz
    {
        public int PedirNum()
        {
        int n1;
        Console.WriteLine("Introduzca un número");
        n1 = Convert.ToInt32(Console.ReadLine());
        return n1;
        }

    }
}
