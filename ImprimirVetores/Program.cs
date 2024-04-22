int[] numeros = new int[10];
int[] impares = new int[10];
int[] pares = new int[10];

for (int i = 0; i < 10 ; i++)
{
    Console.Write("Digite um número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.Write("Números informados: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i] + " ");
}
Console.ReadKey();

Console.Write("\nNúmeros de trás para frente: ");
for (int i = 9; i >= 0; i--)
{
    Console.Write(numeros[i] + " ");
}
Console.ReadKey();

Console.Write("\nNúmeros impresso até a metade do vetor: ");
for (int i = 0; i < 5; i++)
{
    Console.Write(numeros[i] + " ");
}
Console.ReadKey();


Console.Write("\nNúmeros pares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 == 0)
    {
        pares[i] = numeros[i];
        Console.Write(pares[i] + " ");
    }
}
Console.ReadKey();


Console.Write("\nNúmeros impares: ");
for (int i = 0; i < 10; i++)
{
    if (numeros[i] % 2 != 0)
    {
        impares[i] = numeros[i];
        Console.Write(impares[i] + " ");
    }
}
Console.ReadKey();