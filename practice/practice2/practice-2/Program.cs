using System;

namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dada una cadena de dígitos, debes reemplazar cualquier dígito inferior a 5 con '0' y cualquier dígito 5 y superior con '1'. 
            //Devuelve la cadena resultante.
            int [] digitos = new int [10];
            int digits;
            for (int x=0; x<10; x++){
                Console.WriteLine("Ingrese un digito");
                digits= int.Parse(Console.ReadLine());
                digitos[x]= digits;
            }
            for (int x=0; x<10; x++){
                if (digitos[x]<5){
                    digitos[x]=0;
                }else if(digitos[x]>=5){
                    digitos[x]=1;
                }                   
            }
            for (int x=0; x<10; x++){
                Console.Write(digitos[x]);
            }
        }
    }
}
