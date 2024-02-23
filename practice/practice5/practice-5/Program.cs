using System;

namespace practice_5
{
    class Program
    {
        static void Main(string[] args)
        {
        int [] lista = new int [5];
        int numero=0; 
        for (int x=0; x<5; x++){
            Console.WriteLine("Ingrese un numero"); 
            numero = int.Parse(Console.ReadLine());
            lista[x]= numero; 
        }
        int repetido=0, contador=0;   
        for(int x=0; x<5; x++){
                repetido= lista[x];
                contador=0; 
            for(int y=0; y<5; y++){
                if (repetido==lista[y]){
                    contador++; 
                }
            }   
            if (contador>=2){
                repetido=1;
                break;  
            }
        }
            if (repetido==1){
                Console.WriteLine("Sí hay repetidos");
            }else{
                Console.WriteLine("No hay repetidos");
            }


        }
    }
}
