using System;

namespace ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
         // Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.
           int edad, promedio=0, acu=0, con=0;
           for(int x=0; x<20; x++){
            Console.WriteLine("Ingrese la edad");
            edad=int.Parse(Console.ReadLine());
            if (edad>18){
                con++;
                acu+=edad;
            }
           }
           promedio= acu/con;
           Console.WriteLine("El proemdio de las edades mayores a 18 es: "+promedio);
           Console.WriteLine("La cantidad de personas mayores a 18 son: "+con);

            }
            }
    }

