using System;

namespace practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float n=0, n2=0;   
            pedirnumeros( ref n, ref n2);
            float devolver= sumar(n, n2);
            float promedio= promedioo(n,n2);
            Console.WriteLine("El resultado de la suma de los dos numeros ingresados es: "+devolver); 
            Console.WriteLine("El promedio de los numerosS es: "+promedio);
            float mayor= mayormenos(n, n2);
            Console.WriteLine("El numero mayor ingresado es: "+mayor);
            float primoo=primo(n);
            if(primoo==1){
                Console.WriteLine("El primer numero ingresado es par");
            }else{
                Console.WriteLine("El primer numero ingresado es impar");
               }
        } static void pedirnumeros(ref float n1, ref float n2){
            Console.WriteLine("Ingrese un numero");
            n1= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro");
            n2= float.Parse(Console.ReadLine());
        } 
        static float sumar (float n1, float n2){
            float resultado=0; 
            resultado= n1+n2;
            n1=0; 
            return resultado;
        } static float promedioo (float n1, float n2){
            float promedio=0;
            promedio= (n1+n2)/2;
            return promedio;
        } static float mayormenos(float n1, float n2){
            if (n1>n2){
                return n1;
            }else{
                return n2; 
            }
        } static float primo(float n1){
            float primo=0; 
            if (n1%2==0){
                primo=1;
                return primo;
            }else{
                return 0; 
            }
        }
    }
}
