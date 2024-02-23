using System;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n1=0, n2=0, resultado=0; 
        pedirdatos(ref n1, ref n2);
        resultado = n1+n2; 
        Console.WriteLine("La suma de los dos numeros ingresados es de: "+resultado);
        }
     static void pedirdatos(ref int n, ref int n1){
        Console.WriteLine("Ingrese un numero");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro");
        n1 = int.Parse(Console.ReadLine());
     }
    }
}
