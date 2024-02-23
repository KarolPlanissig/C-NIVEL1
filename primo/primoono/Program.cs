using System;

namespace primoono
{
    class Program
    {
        static void Main(string[] args)
        {
            int con=0, n=0;
            Console.WriteLine("Ingrese un numero");
            n= int.Parse(Console.ReadLine());
            for (int x=1; x<=n; x++){
                if (n % x ==0){ //x<=n quiere decir que va a dividir hasta que el numero que ingresó el usuario tenga el valor de x.
                    con++;
                }
            }
            if (con==2){
                Console.WriteLine("Es primo");
            }else{
                Console.WriteLine("No es primo");
            }
        }
    }
}
