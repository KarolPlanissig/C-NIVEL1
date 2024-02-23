using System;

namespace trabajopractico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar las notas y el nombre de un alumno y mostrar por pantalla el alumno con la nota mas alta. 
            int numeros, con=0;  
            string nombresalumnos= "hola";
            int [] numero = new int [3];
            string [] nombres = new string [3];
            for (int x=0; x<3; x++){
                Console.WriteLine("Ingresa la nota del alumno ");
                numeros = int.Parse(Console.ReadLine());
                numero[x]= numeros;
                Console.WriteLine("Ingrese el nombre: ");
                nombresalumnos= Console.ReadLine(); 
                nombres[x]= nombresalumnos;
                con++; 
            }
            int b=0; 
            string primervueltanombre="hola";
            int primervueltanota=0;
            for (int x=0; x<3; x++){
                //Console.WriteLine("La nota del alumno: "+nombres[x]+ " es: " +numero[x]);
                if (b==0){
                    primervueltanombre=nombres[0];
                    primervueltanota=numero[0];
                    b++;
                }else if(numero[x]>primervueltanota){
                    menornota=primervueltanota;
                    primervueltanota=numero[x];
                    primervueltanombre=nombres[x];
                }
            }
                Console.WriteLine("La nota mas alta fue de: "+primervueltanombre+ " con una nota de: "+primervueltanota);
                Console.WriteLine("Se registró una cantidad de : "+con+" alumnos.");
                Console.WriteLine("La nota mas baja fue de: "+menornota); 

        }
    }
}
