// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
Console.WriteLine("Введите количество строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine()); ;
int[,] matrix = new int[m, n];
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
        Console.WriteLine();
    }
}
void AvgInColumn (int[,] matrix)
{double sum = 0;
for(int i = 0; i < matrix.GetLength(1); i++)
{
    
    for (int j = 0; j < matrix.GetLength(0); j++)
    sum += matrix[j, i]; 
    Console.WriteLine($"Среднее арифметическое в столбце {i + 1} = {sum / m}");
    sum = 0; 
} 
}
FillMatrix(matrix);
PrintMatrix(matrix);
AvgInColumn(matrix);