using System;

namespace ultimoejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
            //El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.
            
            
            int n, con=0, contadorlista=0;
            
                do 
                {
                con=0; 
                contadorlista++;
                Console.WriteLine("Ingrese un numero");
                n=int.Parse(Console.ReadLine());
                while (n>0){
                con++;
                Console.WriteLine("Ingrese un numero");
                n=int.Parse(Console.ReadLine());
                }
                Console.WriteLine("La cantidad del grupo: " +contadorlista+ " es: " +con+ " numeros");
               }while(n>=0);
            
        }
    }
}
