using System;

namespace practice_3
{
    class Program
    {
        static void Main(string[] args)
        {
           string dueño ="Jefe";
           string nombre; 
           Console.WriteLine("Ingrese su nombre");
           nombre = Console.ReadLine();
           string nombree= siesjefe(nombre);
            Console.WriteLine("Hola "+ nombree);
           } static string siesjefe(string name){
            string jefecito= "jefe";
            if (name==jefecito){
                return jefecito;
            }else{
                return name; 
            }
           }
        
    }
}
