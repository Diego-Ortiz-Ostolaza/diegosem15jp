using System;

Console.Write("Ingrese # filas: ");
int f = int.Parse(Console.ReadLine());
Console.Write("Ingrese # columnas: ");
int c = int.Parse(Console.ReadLine());

int[,] matriz = new int[f, c];
int[] suma= new int[ c];
Random random = new Random();

Console.WriteLine("\nMatriz Generada Aleatoriamente: \n");

for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {

        matriz[i, j] = random.Next(20, 31);
        Console.Write(matriz[i, j] + "\t");
        suma[j] += matriz [i,j];
    }
    Console.WriteLine();
 
}



Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.ForegroundColor = ConsoleColor.Yellow;

for (int i = 0; i < suma.Length; i++)
{
    Console.Write(suma[i]+"\t");
}
Console.WriteLine();

Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor= ConsoleColor.Yellow;
    for (int j = 0; j < c; j++)
{
    int sum = 0;
    for (int i = 0; i < f; i++)
    {
        sum += matriz[i, j];
    }
    Console.WriteLine($"Suma de columa {j} es {sum}");
}
Console.WriteLine();


Console.ResetColor();
