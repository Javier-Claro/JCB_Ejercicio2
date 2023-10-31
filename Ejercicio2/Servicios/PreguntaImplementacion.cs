using Ejercicio2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2NumernoElevado.Servicios
{
    internal class PreguntaImplemetacion : PreguntaInterfaz
    {
        public double pedirNumero()
        {
            Console.Write("Escriba un numero ");
            double numeroPedido = Convert.ToInt32(Console.ReadLine());
            return numeroPedido;
        }

    }
}