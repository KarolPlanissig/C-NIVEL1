using System;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, referencia=0; 
            Console.WriteLine("Ingrese un numero");
            n= int.Parse(Console.ReadLine());
            PositivoNegativoCero(n, ref referencia);
            Console.WriteLine("El valor es:" +referencia);
        }
     static void PositivoNegativoCero (int n1, ref int estado){
        if (n1==0){
            estado=0;
        }else if(n1>0){
            estado=1;
        }else{
            estado=-1;
        }
    }
    }
    

}
