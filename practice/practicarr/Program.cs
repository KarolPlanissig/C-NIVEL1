using System;

namespace practicarr
{
    class Program
{
        static void Main(string[] args)
    {
        //Hacer un programa que solicite una lista de numeros que corta cuando se ingresa un 0 y luego emitir por pantalla el maximo
        // de los numeros negativos y el minimo de los numeros positivos. 
        int numero=0; 
        int MaxNega=0;
        int MinPosi=0;
        int vueltaPosi=0;
        int vueltaNega=0;  
        Console.WriteLine("Ingrese un numero"); 
        numero = int.Parse(Console.ReadLine()); 
        while(numero!=0){
            if(numero>0){
                if (vueltaPosi==0){
                    MinPosi=numero;
                    vueltaPosi++; 
                }else if (numero<MinPosi){
                    MinPosi= numero; 
                }
                }else if(numero<0){
                if(vueltaNega==0){
                    MaxNega=numero; 
                    vueltaNega++; 
                }else if(numero>MaxNega){
                    MaxNega=numero; 
                }   

            }    
            
            
            Console.WriteLine("Ingrese un numero"); 
            numero = int.Parse(Console.ReadLine()); 
        }
        Console.WriteLine("El mayor de los negativos ingresados es el: "+MaxNega);
        Console.WriteLine("El minimo de los positivos ingresados es el: "+MinPosi);  

        
    }
}
}