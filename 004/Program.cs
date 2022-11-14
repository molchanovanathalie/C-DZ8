// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void Pascal(int size)
{
int[,] pascal = new int[size, size];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
        if (i == j || j == 0)
        {
            pascal[i, j] = 1;
        }
        else if (j > i)
        {
           pascal[i, j] = 0; // как вместо нуля поставить пробел?
        }
        else if (i != j)
        {
            pascal[i, j] = pascal[i - 1, j - 1] + pascal[i - 1, j];
        }
        
        Console.Write($"{pascal[i, j]}" +"\t");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите размер: ");
int size = int.Parse(Console.ReadLine() ?? "0");
Pascal(size);



