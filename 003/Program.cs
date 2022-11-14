//Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          for (int y = 0; y < array.GetLength(2); y++ )
            array[i, j, y] = new Random().Next(10, 99);
        }
    }
}
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
          for (int y = 0; y < array.GetLength(2); y++ ) 
          Console.Write($"Элемент массива {array[i, j, y]} имеет индекс [{i}] [{j}] [{y}] " + "\n");
        } 
    }
}

int i = 2;
int j = 2;
int y = 2;
int[,,] array = new int[i, j, y];
FillArray(array);
PrintArray(array);
Console.WriteLine();



