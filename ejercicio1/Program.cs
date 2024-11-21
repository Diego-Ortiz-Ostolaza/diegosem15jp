
Console.Write("Ingrese # filas: ");
int f = int.Parse(Console.ReadLine());
Console.Write("Ingrese # columnas: ");
int c = int.Parse(Console.ReadLine());

int[,] matriz= new int[f,c];

Random random = new Random();

Console.WriteLine("\nMatriz Generada Aleatoriamente: \n");

for (int i = 0; i < f; i++)
{
    for (int j = 0; j < c; j++)
    {

        matriz[i,j] = random.Next(30,51);
        Console.Write(matriz[i,j]+"\t");
        
    }
    Console.WriteLine();
}

Console.ReadKey();
return 0;




