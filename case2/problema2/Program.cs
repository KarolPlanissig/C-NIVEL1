using System;

namespace problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            float litros=100; 
            float importe=0;
            Console.WriteLine("Ingrese la cantidad de litros vendida");
            litros= float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el importe de la venta");
            importe= float.Parse (Console.ReadLine());
            if(litros>500){
                importe= importe * 0.75f;
            }else if (litros >=101 && litros <=300){
                importe= importe* 0.90f;
            }else if (litros >=301 && litros <=500 ){
                importe= importe * 0.85f;
            }else{
                Console.WriteLine("No hay descuento");
            }
            Console.WriteLine("El importe a pagar: " +importe);
        }
    }
}
