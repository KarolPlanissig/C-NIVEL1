using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        //Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es.        }
        int n; 
        int conpar=0, acu=0;
        float promedioprimo=0; 
        Console.WriteLine("Ingrese un numero");
        n = int.Parse(Console.ReadLine());
        while(n!=0){
           int x = primo(n);
           if(x==1){
            conpar++;
            acu+=n; 
           }
            Console.WriteLine("Ingrese otro..");
            n= int.Parse(Console.ReadLine());
        }
        promedioprimo= acu/conpar;
        Console.WriteLine("El promedio de los numeros primos es de: "+promedioprimo);

    }
        static int primo(int n){
           int con=0;
            for (int x=1; x<=n; x++){
                if (n%x==0){
                    con++; 
                }
            }
            if (con==2){
                return 1; 
            }else{
                return 0; 
            }
        }
}
}