using System;

namespace ejerciciosvector4
{
    class Program
    {
        static void Main(string[] args)
        {
            //char [] nombre = new char [10];
            //char caracter;
            //for (int x=0; x<10; x++){
              //  Console.WriteLine("Ingrese un caracter");
                //caracter = char.Parse(Console.ReadLine());
                //nombre [x]= caracter;
            
            //for (int x=0; x<10; x++){
              //  Console.Write(nombre[x]);
            
        // programacion bajo nivel todo lo de arriba, es todo lo que pasa cuando queremos cargar un nombre letra por letra..
         string nombre;
         Console.WriteLine("Ingrese su numbre");
         nombre= Console.ReadLine();
         nombre= nombre.ToUpper();
         Console.WriteLine("Hola "+nombre);
        
         //ahora arriba, programacion de alto nivel. Todo lo que nos ahorra, no hace falta cargar letra por letra.

            
        
         }
    }
}
