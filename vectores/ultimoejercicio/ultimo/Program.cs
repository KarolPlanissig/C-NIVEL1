using System;

namespace ultimo
{
    class Program
    {
        static void Main(string[] args)
        {
            char [] caracter = new char [20];
            char cargadechar;
            for (int x=0; x<20; x++){
                Console.WriteLine("Ingrese el caracter");
                cargadechar= char.Parse(Console.ReadLine());
                caracter[x]= cargadechar;

            }
            char reemplazo = 'e';
            for (int x=0; x<20; x++){
                if (caracter[x]=='a'){
                    caracter[x]=reemplazo;
                }
            }
            for (int x=0; x<20; x++){
                Console.Write(caracter[x]);
            }
        
        }
    }
}
