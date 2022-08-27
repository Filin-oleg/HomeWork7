// Напишите программу, которая на вход принимает число, и возвращает индексы этого элемента 
//или же указание, что такого элемента нет.

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
            matrix[i, j] = new Random().Next(1, 100);
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
FillMatrix(matrix);
PrintMatrix(matrix);    //для простоты проверки!
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
void FindNumber(int[,] matrix, int number)
{
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"Введенное Вами число содержится в элементе массива с индексом [{i}], [{j}]");
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine("В заданном массиве введенного вами числа нет ");
    }
}
FindNumber(matrix, number);
PrintMatrix(matrix);
