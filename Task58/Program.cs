// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6}", matrix[i, j]));
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите кол-во строк в матрицах");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов в матрицах");
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);
Console.WriteLine("Первая матрица");
PrintMatrix(firstMatrix);
Console.WriteLine("Вторая матрица");
PrintMatrix(secondMatrix);
Console.WriteLine();
int[,] resultMatrix = new int[m,n];
 for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatrix.GetLength(1); k++)
      {
        sum += firstMatrix[i,k] * secondMatrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
  Console.WriteLine("Произведение первой и второй матриц:");
PrintMatrix(resultMatrix);