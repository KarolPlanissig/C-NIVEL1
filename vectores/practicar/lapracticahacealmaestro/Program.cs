using System;

namespace lapracticahacealmaestro
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] edades= new int [5];
            int edad;
            for (int x=0; x<5; x++){
                Console.WriteLine("Ingrese una edad");
                edad= int.Parse(Console.ReadLine());
                edades[x]=edad; 
            }
            int mayor=0, posicion=0, bandera=0; 
            for (int x=0; x<5; x++){
                if (bandera==0){
                    mayor=edades[x];
                    posicion=(x+1);
                    bandera++;
                }else if(mayor<edades[x]){
                    mayor=edades[x];
                    posicion=(x+1);
            }
            }
            int contador=0; 
            for (int x=0; x<5; x++){
                if (edades[x]>=18){
                    contador++;
            }
            }
                Console.WriteLine("La mayor edad ingresada es: "+mayor);
                Console.WriteLine("Fue ingresado en la posicion: "+posicion);
               if (contador==0){
                Console.WriteLine("No hubo personas registradas que sean mayores de edad");
               }else{
                Console.WriteLine ("La cantidad de mayores de edad son de: "+contador);
               } 
        }

    }
}
