using System;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
           bool banderapar=false;
           int n , banderaimpar=0, maximopar=0, minimoimpar=0;
            for (int x=0; x<5; x++){
               Console.WriteLine("Ingrese un numero");
               n= int.Parse(Console.ReadLine());
                if (n%2==0){
                    
                    if (banderapar==false){
                        maximopar=n;
                       banderapar=true; 
                    }else if(n>maximopar){
                        maximopar=n; 
                    }
                }else if (banderaimpar==0){
                    minimoimpar=n;
                    banderaimpar=1;
                }else if (n<minimoimpar){
                    minimoimpar=n; 
                }

            }
            Console.WriteLine("El maximo de los numeros par es: " +maximopar);
            Console.WriteLine("El minimo de los numeros impares es: " +minimoimpar);
        
        }
    }
}
