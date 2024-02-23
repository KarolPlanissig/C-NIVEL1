using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, acu=0, max=0, indice=0;  
            int [] numeros = new int [10];  //sintaxis de cómo crear un vector en C#. (IMPORTANTE).
            for (int x=0; x<9; x++){
                Console.WriteLine("Ingrese un numero");
                numero= int.Parse(Console.ReadLine());
                numeros [x]= numero;
            }
            for (int x=0; x<9; x++){
                acu+= numeros[x];
                Console.WriteLine("El numero cargado en el  indice es: "+x+ " es: "+numeros[x]);
                if (numeros[x]>max){
                    max= numeros[x];
                    indice=x;
                }
            }
                Console.WriteLine("El numero mas grande cargado es el: "+max);
                Console.WriteLine("La suma de los valores agredados a los indices es de: "+acu);
                Console.WriteLine ("El indice con mayor valor es el indice: "+indice);
        }

    }
}
