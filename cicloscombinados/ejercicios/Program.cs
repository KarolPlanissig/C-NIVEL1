using System;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
         
          float n1, n2, resultado; 
          Console.WriteLine("iNGRESE UN NUMERO"); 
          n1= float.Parse(Console.ReadLine());
          Console.WriteLine("Ingrese el segundo numero"); 
          n2 = float.Parse(Console.ReadLine()); 
          resultado= (n1+n2)/2;
         Console.WriteLine("El resultado es: "+resultado); 
           
                    
    }
    }                
            
}      
