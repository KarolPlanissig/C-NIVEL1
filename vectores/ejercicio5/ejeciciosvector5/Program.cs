using System;

namespace ejeciciosvector5
{
    class Program
    {
        static void Main(string[] args)
        {
            int mayorvendido, art=1;
            int [] articulo = new int [15];
            int [] contador = new int [15];
            for (int x=0; x<15; x++){
                contador[x]=0; 
            }
            for (int x=0; x<15; x++){
                if(articulo [x]==0){
                    Console.WriteLine("El articulo " +(x+1)+ " no registro ventas");
                }
            }
            mayorvendido=contador [0];
             for(int x=0; x<15; x++){
            if(contador[x]>mayorvendido){
                mayorvendido=contador[x];
                art=x+1;
            }
        }
        Console.WriteLine("El articulo que mas se vendió es: "+art+ "con una cantidad de ventas de: "+mayorvendido);
       
        }
    }
}
