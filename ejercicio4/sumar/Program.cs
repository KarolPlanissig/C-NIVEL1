using System;

namespace sumar
{
    class Program
    {
        static void Main(string[] args)
        {
            //4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos
            // primeros es mayor al producto del segundo con el tercero.

            int n1, n2, n3, dosprimeros, producto; 
            Console.WriteLine("Ingrese un numero");
            n1=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo numero");
            n2= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un tercer numero");
            n3= int.Parse(Console.ReadLine());
             dosprimeros = n1+n2; 
             producto= n2 *n3;
             if (dosprimeros>producto){
                Console.WriteLine("La suma de los dos primeros es mayor al producto"); 
             }



                }
    }
}
