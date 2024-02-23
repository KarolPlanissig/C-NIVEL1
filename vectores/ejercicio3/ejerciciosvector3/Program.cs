using System;

namespace ejerciciosvector3
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] caracter = new char [5];
            char n='x'; 
            for (int x=0; x<5; x++){
                Console.WriteLine("Ingresa un caracter");
                n= char.Parse(Console.ReadLine());
                caracter [x]= n; 
            }
            for (int x=0; x<5; x++){
                caracter[x]= char.ToUpper(caracter[x]);
            }
            for(int x=0; x<5; x++){
                Console.Write(caracter[x]); 
            }
            for( int x=0; x<5; x++){
                caracter[x]= char.ToLower(caracter[x]);

            }
            for (int x=0; x<5; x++){
                Console.Write(caracter[x]); 
            }
            string
        }

    }
}
