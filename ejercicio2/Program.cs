Console.Write("Ingrese # matriz: ");
int num =int.Parse(Console.ReadLine());

int[,]matriz = new int[num,num];
int[,] transpuesta = new int[num, num];
Random rand = new Random();


Console.WriteLine("\nMatriz original: ");
for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        matriz[i,j] = rand.Next(48,51);
        Console.Write(matriz[i,j]+"\t");
    }
    Console.WriteLine();
}



Console.WriteLine("\nMatriz transpuesta: ");
for (int j = 0; j < num; j++)
{
    for (int i = 0; i < num; i++)
    {
        transpuesta[j,i]=matriz[i,j];
    }
}



for (int i = 0; i < num; i++)
{
    for (int j = 0; j < num; j++)
    {
        Console.Write(transpuesta[i, j] + "\t");
    }
    Console.WriteLine();
}









