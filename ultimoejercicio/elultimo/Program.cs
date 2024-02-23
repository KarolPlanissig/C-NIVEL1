using System;

namespace elultimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, memoria, disco; 
            float precio=0; 
                Console.WriteLine("Ingrese la opcion de procesador");
                procesador = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la opcion de memoria");
                memoria= int.Parse(Console.ReadLine()); 
                Console.WriteLine("Amplia disco?");
                disco= int.Parse(Console.ReadLine()); 
                switch(procesador){
                    case 1: 
                    switch(memoria){
                        case 1: 
                        precio=800;
                        break;
                        case 2: 
                        precio=900;
                        break; 
                        case 3:
                        precio= 1000;
                        break;
                        default:
                        Console.WriteLine("No seleccionaste ninguna opcion");
                        break; 
                    }
                    break;
                    case 2:
                        switch(memoria){
                            case 1:
                            precio=900;
                            break; 
                            case 2:
                            precio=1000;
                            break;
                            case 3:
                            precio= 1400;
                            break; 
                            default:
                            Console.WriteLine("No seleccionaste ninguna opcion");
                            break; 
                        }
                        break; 
                    case 3:
                    switch (memoria){
                        case 1:
                        precio=1200;
                        break;
                        case 2: 
                        precio=1400;
                        break; 
                        case 3: 
                        precio= 2000; 
                        break; 
                        default:
                        Console.WriteLine("No seleccionaste ninguna opcion");
                        break; 
                    }
                    break; 
                    default:
                    Console.WriteLine("No seleccionaste ninguna opcio");
                    break;
                }
                if (disco==1){
                    precio = precio + 300; 

                }
                Console.WriteLine("El importe a pagar es de: " +precio);
            }
    }
}
