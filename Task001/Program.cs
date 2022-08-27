// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.WriteLine("Введите количество строк массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива ");
int n = Convert.ToInt32(Console.ReadLine());;
double[,] matrix = new double[m, n];
void FillMatrix(double [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10) + Math.Round(new Random().NextDouble(), 4);
        }
    }
}
void PrintMatrix(double [,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"[{matrix[i, j]}] ");
        }
        Console.WriteLine();
    }
}
FillMatrix(matrix);
PrintMatrix(matrix);