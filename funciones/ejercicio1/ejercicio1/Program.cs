using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           //Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
            int precio, cantidad, monto; 
            Console.WriteLine("Ingrese el precio del producto");
            precio= int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida");
            cantidad= int.Parse(Console.ReadLine());
            monto= producto(precio, cantidad);
            Console.WriteLine("El monto a pagar es de: "+monto);

        }
        static int producto (int n1, int n2){
            int resultado=0; 
            resultado= n1 * n2;  
            return resultado; 
        }
    }
}
