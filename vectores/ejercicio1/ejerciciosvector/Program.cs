using System;

namespace ejerciciosvector
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int n, valormaximo, bandera;
            int [] numeros = new int [5];
            for(int x=0; x<5; x++){
                Console.WriteLine("Ingrese un numero");
                n= int.Parse(Console.ReadLine());
                numeros[x]= n;
            }
            bandera=0; 
            valormaximo=0;
            for (int x=0; x<5; x++){
               if (bandera==0){
                valormaximo=numeros[x];
                bandera=1;
               }else if (numeros[x]>valormaximo){
                valormaximo= numeros[x];
                bandera=x+1;
               }
            }
               
            Console.WriteLine("El valor maximo ingresado es: "+valormaximo);
            Console.WriteLine ("Su posicion dentro del vector es: "+bandera);       
            
            
        }
    }
}
