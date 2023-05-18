// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a=10;
b=a;
Console.WriteLine("Valor de a: "+a);
Console.WriteLine("Valor de b: "+b);

float num1=0;
bool anda = false;
string? numString = "";

while(!anda)
{
    Console.WriteLine("Ingrese un numero valido: ");
    numString=Console.ReadLine();
    anda=float.TryParse(numString, out num1);
    
    if (!anda)
    {
        Console.WriteLine(numString + " no es numero valido");
    } else {
        Console.WriteLine("El numero ingresado es "+num1);
    }
}