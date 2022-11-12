// Найти произведение двух матриц
void FillArray(int[,] matrix, int[,] matrix1)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j< matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(4, 15);
        }
    }
}

void PrintArray(int[,] matrix, int[,] matrix1)
{
    for (int i = 0; i < matrix.GetLength(0);i++)
    {
        for (int j = 0;j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            Console.Write($"{matrix1[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matrix, int[,] matrix1, int[,] compMatr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            compMatr[i, j] = matrix[i, j] * matrix1[i, j];
        }
    }
}

void PrintCompArray(int[,] compMatr)
{
    for (int i = 0; i < compMatr.GetLength(0); i++)
    {
        for (int j= 0; j < compMatr.GetLength(1); j++)
        {
            Console.Write($"{compMatr[i, j]}\t");
        }
        Console.WriteLine();
    }
}


int[,] matrix = new int[4, 4];
int[,] matrix1 = new int[4, 4];
int[,] compMatrix = new int[4, 4];
FillArray(matrix, matrix1);
PrintArray(matrix, matrix1);
Console.WriteLine();
Composition(matrix, matrix1, compMatrix);
PrintCompArray(compMatrix);