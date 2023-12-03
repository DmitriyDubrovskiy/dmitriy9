using System;
using System.Linq;

class MathOperations
{
    // Перевантажений метод для додавання двох чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Перевантажений метод для додавання масивів чисел
    public static int[] Add(int[] array1, int[] array2)
    {
        if (array1.Length != array2.Length)
        {
            throw new ArgumentException("Arrays must have the same length");
        }

        int[] result = new int[array1.Length];
        for (int i = 0; i < array1.Length; i++)
        {
            result[i] = array1[i] + array2[i];
        }

        return result;
    }

    // Перевантажений метод для додавання матриць
    public static int[][] Add(int[][] matrix1, int[][] matrix2)
    {
        if (matrix1.Length != matrix2.Length || matrix1[0].Length != matrix2[0].Length)
        {
            throw new ArgumentException("Matrices must have the same dimensions");
        }

        int rows = matrix1.Length;
        int cols = matrix1[0].Length;

        int[][] result = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            result[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                result[i][j] = matrix1[i][j] + matrix2[i][j];
            }
        }

        return result;
    }

    // Додаткові методи для віднімання, множення, тощо можна додати подібним чином
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 3;
        int sum = MathOperations.Add(a, b);
        Console.WriteLine($"Sum of {a} and {b} is {sum}");

        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] arraySum = MathOperations.Add(array1, array2);
        Console.WriteLine("Array sum: " + string.Join(", ", arraySum));

        int[][] matrix1 = new int[][] { new int[] { 1, 2 }, new int[] { 3, 4 } };
        int[][] matrix2 = new int[][] { new int[] { 5, 6 }, new int[] { 7, 8 } };
        int[][] matrixSum = MathOperations.Add(matrix1, matrix2);
        Console.WriteLine("Matrix sum:");
        for (int i = 0; i < matrixSum.Length; i++)
        {
            Console.WriteLine(string.Join(", ", matrixSum[i]));
        }
    }
}
