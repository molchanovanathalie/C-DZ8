// Найти произведение двух матриц
void FillArray(int[,] matrix, int[,] matrix1)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            matrix[m, n] = new Random().Next(1, 10);
        }
    }
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
            matrix1[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matrix, int[,] matrix1)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            Console.Write($"{matrix[m, n]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    for (int m = 0; m < matrix1.GetLength(0); m++)
    {
        for (int n = 0; n < matrix1.GetLength(1); n++)
        {
            Console.Write($"{matrix1[m, n]}\t");
        }
        Console.WriteLine();
    }
}

void Composition(int[,] matrix, int[,] matrix1, int[,] compMatr)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n < matrix.GetLength(1); n++)
        {
            compMatr[m, n] = matrix[m, n] * matrix1[m, n];
        }
    }
}

void PrintCompArray(int[,] compMatr)
{
    for (int m = 0; m < compMatr.GetLength(0); m++)
    {
        for (int n = 0; n < compMatr.GetLength(1); n++)
        {
            Console.Write($"{compMatr[m, n]}\t");
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