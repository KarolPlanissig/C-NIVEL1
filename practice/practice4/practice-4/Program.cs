
using System;

namespace practice_4
{
    class Program
    {
        static void Main(string[] args)
        {   //Este kata consiste en multiplicar un número determinado por ocho si es par y por nueve en caso contrario.
        int n1, n2, resultado=0, opcion=0; 
        Console.WriteLine("Ingresame un numero: ");
        n1= int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo bro: ");
        n2= int.Parse(Console.ReadLine());
        resultado= n1+n2; 
        Console.WriteLine("El resultado es: "+resultado);
        Console.WriteLine("Deseas multiplicarlos? Ingresa 1 para sí.");
        opcion= int.Parse(Console.ReadLine());
        if(opcion==1){
            resultado= n1*n2; 
            Console.WriteLine("El resultado de la multiplicación es: "+resultado);
        }
        int motivacion=0; 
        Console.WriteLine("Deseas recibir un mensaje de motivación? Ingresa 1 para sí.");
        motivacion= int.Parse(Console.ReadLine());
        if(motivacion==1){
        for(int x=0; x<10; x++){
            Console.WriteLine("Vos podes cliaw, no te rindas!!");
            
        }
        }
        }
    }
}
