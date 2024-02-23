using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] numeros = new int[5];
        int carga, con=0; 
        for (int x=0; x<5; x++){
            Console.WriteLine("Ingrese un numero");
            carga= int.Parse(Console.ReadLine()); 
            numeros [x]= carga; 
        }            
        for(int x=0; x<5; x++){
            numeropar(numeros[x]);
            int n=numeropar(numeros[x]);
            if (n==1){
                Console.WriteLine("El numero: " +numeros[x] +"es par");
                con++;
            }else{
                Console.WriteLine("El numero: " +numeros[x] +"es impar");
            }
        }
                Console.WriteLine("La cantidad de numeros pares es de: "+con); 
        }
        static int numeropar(int n){
            int par;
            if (n%2==0){
                par=1; 
            }else{
               par=0;
            }
            return par; 
            }
    }

}
