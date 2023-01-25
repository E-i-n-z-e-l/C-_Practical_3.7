// Задача 48. Задайте двумерный массив m на n, каждый элемент в массиве находится по формуле: Amn = m + n. Выведите полученный массив на экран.

int [,] CreateMatrixInt(int rows, int columns) 
{
	int[,] matrix = new int[rows, columns];

	for (int i = 0; i < matrix.GetLength(0); i++) 
	{
		for (int j = 0; j < matrix.GetLength(1); j++) 
		{
			matrix[i, j] = i + j;
		}
	}
	return matrix;
}

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{	
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
			else Console.Write($"{matrix[i, j], 5} ");
		}	
		Console.WriteLine("]");
    }
}

int [,] array = CreateMatrixInt(4, 5);
PrintMatrix(array);
