// Задача 49. Задайте двумерный массив. Найдите элементы, у которых обаиндекса четные, и замените эти элементы на их квадраты.

int [,] CreateMatrixRndInt(int rows, int columns, int min, int max) 
{
	int[,] matrix = new int[rows, columns];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) 
	{
		for (int j = 0; j < matrix.GetLength(1); j++) 
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
			if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, ");
			else Console.Write($"{matrix[i, j], 5} ");
		}	
		Console.WriteLine("]");
    }
}

int [,] SquareOfEvenIndex (int [,] array)
{	
	for (int i = 0; i < array.GetLength(0); i++) 
	{
		for (int j = 0; j < array.GetLength(1); j++) 
		{
			if (i % 2 == 0 & j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
		}
	}
    return array;
}

int [,] array = CreateMatrixRndInt(4, 5, 4, 5);
PrintMatrix(array);
Console.WriteLine();
int [,] newArray = SquareOfEvenIndex(array);
PrintMatrix(newArray);