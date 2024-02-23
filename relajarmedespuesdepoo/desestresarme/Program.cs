// See   for more information

int [] numeros = new int [5];
int carga; 
for(int x=0; x<5; x++){
Console.WriteLine("Ingrese un numero");
carga= int.Parse(Console.ReadLine()); 
numeros[x]= carga; 
}
for(int x=0; x<5; x++){
    Console.WriteLine("El numero cargado en este indice es: "+numeros[x]); 
}
for (int x=0; x<4; x++){
    if(numeros[x]==numeros[x+1]){
        Console.WriteLine("El numero cargado en el indice "+x+" es igual al numero cargado en el indice "+(x+1));
    }
    
}