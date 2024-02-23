using System;

namespace ejerciciosvector2
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio.
           //Mostrar por pantalla los valores que son mayores al promedio
           int n, acu=0, promedio=0; 
           int [] vector = new int [10];
           for (int x=0; x<10; x++){
            Console.WriteLine("Ingrese un numero entero");
            n= int.Parse (Console.ReadLine());
            vector[x]=n; 
           }
           for (int x=0; x<10; x++){
            acu+=vector[x];
           }
           promedio = acu/10; 
           Console.WriteLine("El promedio es: "+promedio);
           for (int x=0; x<10; x++){
            if (vector[x]>promedio){
                Console.WriteLine("El indice " +x+ " es mayor al promedio");
            }
        }
        
        }
    }
}
