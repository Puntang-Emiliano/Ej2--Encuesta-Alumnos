using System;

namespace Ej2__Encuesta_Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int publico=0, privado=0,  contador=1, acum=0;
            int porPrivado=0, PorPublico=0;
            string opcion = "";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            for (contador = 1; opcion != "s" && opcion != "S"; contador++)
            {
                Console.WriteLine("*/*/*/*/ BIENBENIDO A LA ESCUESTA COLEGIOS */*/*/*/");
                Console.WriteLine("SELECCIONE LA OPCION CORRESPONDIENTE");
                Console.WriteLine("DIGITE A QUE COLEGIO ASISTE");
                Console.WriteLine("A - COLEGIO PUBLICO");
                Console.WriteLine("B - COLEGIO PRIVADO");
                Console.WriteLine("S - SALIR DE LA ENCUESTA");
               


                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "A" or "a":
                        publico = publico +1;
                        acum++;
                        Console.Clear();

                        break;
                    case "B" or "b":
                        privado = privado+1;
                        acum++;
                        Console.Clear();
                        break;

                    case "S" or "s":
                    Console.WriteLine("Selecciono salir");
                    Console.Clear();
                    break;


                    default:
                        System.Console.WriteLine("Opcion no valida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            System.Console.WriteLine("Salimos del programa.....");
           
            
            Console.WriteLine("Asisten a publicos: {0} " , publico);
            Console.WriteLine("Asisten a privados: {0} " , privado);

            porPrivado = (privado * 100) /acum;
            PorPublico = (publico * 100) /acum;
            Console.WriteLine(" El Porcentaje que Asisten a publicos: % {0} " , PorPublico);
            Console.WriteLine("El Porcentaje que Asisten a publicos: % {0} " , porPrivado);
            



        }
    }
}
