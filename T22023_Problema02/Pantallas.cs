using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T22023_Problema02
{
    
    public class Pantallas
    {
        public static float[] notas = new float[100];
        public static string[] nombres = new string[100];
        public static int contador;
        public static int pantallaPrincipal()
        {
            string texto =
            "================================" +
                "\nNotas de estudiantes" +
                "\n================================" +
                "\n1: Ingresar nota" +
                "\n2: Nota más mayor" +
                "\n3: Nota más menor" +             
                "\n4: Ver notas registradas" +
                "\n5: Salir" +
                "\n================================\n";
            Console.Write(texto);

            return operaciones.getEntero("Ingresa una opcion: ", texto);

        }

        public static int Registrar() {
            Console.Write("=======================\n"+
                "Nota mas alta \n"+
                "=======================\n"+
                "Estudiante:Jose maria\n"+
                "nota:  20\n"+
                "=======================\n"+
                "Presione enter para volver\n"+
                "=======================\n");



            return 0;
        
        }
        public static int RegistrarNota()
        {
            string texto1="================================\n"+
            "Ingresar Nota\n"+
            "================================\n";
            Console.WriteLine(texto1);
            string nombre = operaciones.getTextoPantalla("Ingrese el nombre: ");
            float notaRegistrar = operaciones.getDecimal("Ingrese la nota: ");

            if (contador == 100)
            {
                Console.WriteLine("La lista está llena");
            }
            nombres[contador] = nombre;
            notas[contador] = notaRegistrar;
            contador++;

         string texto="================================\n"+
          "!Guardado!\n"+
            "================================\n";

            Console.WriteLine("1: Agregar uno más | 2: Volver");
            int opcion = operaciones.getEntero("Ingresa una opción: ",texto);

            if (opcion == 2) return 0;

            return opcion;
        }
        /*
         public static int NotaMayor()
         {
             string texto = "================================\r\n" +
                 "Nota mas alta\r\n" +
                 "================================\r\n";

             Console.Write(texto);
             if (contador == 0)
             {
                 Console.WriteLine("No existen notas todavía");
             }
             else
             {
                 float mayor = notas[0];
                 int posicioMayor = 0;
                 for (int i = 0; i < contador; i++)
                 {
                     if (notas[i] > mayor)
                     {
                         mayor = notas[i];
                         posicioMayor = i;
                     }
                 }

                 Console.WriteLine("La nota mayor es: " + mayor);

                 for (int i = 0; i < contador; i++)
                 {
                     if (i == posicioMayor)
                     {
                         Console.Write("[" + notas[i] + "] ");
                     }
                     else
                     {
                         Console.Write(notas[i] + " ");
                     }
                 }

                 Console.WriteLine("\n================================");

             }

             string texto2 = "\n1: Regresar\n";
             Console.Write(texto2);

             int opcion = operaciones.getEntero("Ingresa una opción: ", texto);
             if (opcion == 1) return 0;

             return opcion;
         }*/
        public static int NotaMayor()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Nota más alta");
            Console.WriteLine("================================");

            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float mayor = notas[0];
                int posicioMayor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] > mayor)
                    {
                        mayor = notas[i];
                        posicioMayor = i;
                    }
                }

                Console.WriteLine("Estudiante: " + nombres[posicioMayor]); // Muestra el nombre del estudiante
                Console.WriteLine("Nota: " + mayor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMayor)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");

            }

            Console.WriteLine("Presione Enter para volver");
            Console.WriteLine("================================");

            Console.ReadLine();

            return 0;
        }

        public static int NotaMenor()
        {
            Console.WriteLine("================================");
            Console.WriteLine("Nota más baja");
            Console.WriteLine("================================");

            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                float menor = notas[0];
                int posicioMenor = 0;
                for (int i = 0; i < contador; i++)
                {
                    if (notas[i] < menor)
                    {
                        menor = notas[i];
                        posicioMenor = i;
                    }
                }

                Console.WriteLine("Estudiante: " + nombres[posicioMenor]); 
                Console.WriteLine("Nota: " + menor);

                for (int i = 0; i < contador; i++)
                {
                    if (i == posicioMenor)
                    {
                        Console.Write("[" + notas[i] + "] ");
                    }
                    else
                    {
                        Console.Write(notas[i] + " ");
                    }
                }

                Console.WriteLine("\n================================");
            }

            Console.WriteLine("Presione Enter para volver");
            Console.WriteLine("================================");

            Console.ReadLine();

            return 0;
        }

        public static int VerNotas()
        {
            string texto1 = "================================\n" +
             "Lista de estudiantes\n" +
             "================================\n";
            Console.WriteLine(texto1);
            if (contador == 0)
            {
                Console.WriteLine("No existen notas todavía");
            }
            else
            {
                for (int i = 0; i < contador; i++)
                {
                    Console.WriteLine("Nombre: " + nombres[i] + "\tNota: " + notas[i]);
                }
            }

            Console.WriteLine("================================");
            Console.WriteLine("Presione Enter para volver");
            Console.WriteLine("================================");

            Console.ReadLine();

            return 0;
        }
    }
}
