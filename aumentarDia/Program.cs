using System;

namespace EjercicioC
{
    public class program
    {
        static void Main()
            //Algoritmo diseñado por Jhon Ortiz

        {   
            int año, mes, dia;

            Console.WriteLine("Por favor Digite el año");
            año = Convert.ToInt32(Console.ReadLine());


            if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
            {
                Console.WriteLine("El año si es biciesto");
                Console.WriteLine("");
                Console.WriteLine("Digite el mes");
                mes = Convert.ToInt32(Console.ReadLine());


                if (mes < 13)
                {
                    Console.WriteLine("Digite el dia");
                    dia = Convert.ToInt32(Console.ReadLine());
                    if (dia < 32)
                    {
                        dia=dia+1;
                        Console.WriteLine("El dia siguente es: ", año,":",mes,":",dia);

                    }
                    else
                    {
                        Console.WriteLine("ese dia no existe");
                    }
                }
                else
                {
                    Console.WriteLine("el mes no existe");
                }
            }
            else
            {
                Console.WriteLine("El año no es biciesto");
                Console.WriteLine("");
                Console.WriteLine("Digite el mes");
                mes = Convert.ToInt32(Console.ReadLine());

                if (mes < 13)
                {
                    Console.WriteLine("Digite el dia");
                    dia = Convert.ToInt32(Console.ReadLine());
                    if (dia < 32)
                    {
                        dia=dia+1;
                        Console.WriteLine("El dia siguente es: ", año, ":", mes, ":", dia);
                    }
                    else
                    {
                        Console.WriteLine("ese dia no existe");
                    }
                }
                else
                {
                    Console.WriteLine("ese mes no existe");
                }
            }
        }
    }






}
