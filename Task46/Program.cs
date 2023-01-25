// Задача 46. Задайте двумерный массив размером m*n, заполненный целыми числами.

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) // [,] - запятая отображает, что массив двумерный;
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) означает, что мы выбрали именно строки - "(0)" это индекс строки);
	{
		for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - это столбики;
		{
			matrix[i, j] = rnd.Next(min, max + 1);
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
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4}, ");
			else Console.Write($"{matrix[i, j], 4} ");
		}	
		Console.WriteLine("]");
    }
}

int [,] twoDimensionalArray = CreateMatrixRndInt(5, 6, 1, 9);
PrintMatrix(twoDimensionalArray);
