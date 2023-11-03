using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22023_Problema02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                Console.Clear();
                switch (opcion)
                {
                    case 0:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                    case 1:
                        opcion = Pantallas.RegistrarNota();
                        break;
                    case 2:
                        opcion = Pantallas.NotaMayor();
                        break;
                    case 3:
                        opcion = Pantallas.NotaMenor();
                        break;
                    case 4:
                        opcion = Pantallas.VerNotas();
                        break;
                             }

            } while (opcion != 5);
        }
    }
}
