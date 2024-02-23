int edades, contador=0, acu=0, resultado=0; 
for (int x=0; x<5; x++){
    Console.WriteLine("Ingrese la edad");
    edades= int.Parse(Console.ReadLine());
    if(edades>18){
        acu+=edades; 
        contador++; 
    }
}
 resultado= acu/contador; 
Console.WriteLine("El promedio de las personas mayores a 18 es de: "+resultado);
Console.WriteLine(contador+" eran mayores de edad. "); 
