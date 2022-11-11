// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

bool IsValid(int row, int colums)
{
    if (row > 0 && colums >0)return true;
    else return false;
}

int Input(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

double[,] FillArray(int row, int colums, int min, int max)
{
    double[,] arr = new double[row,colums];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() * (max - min) + min, 2);
        }
    }
    return arr;
}

void PtintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + ": ");
        }
        Console.WriteLine();
    }
}

int row = Input("Введите количество строк массива row=");
int colums = Input("Введите количество столбцов массива colums=");
int min = Input("Введите начало диапазона min=");
int max = Input("Введите окончание диапазона max=");
if (IsValid(row, colums)) 
{
    double[,] Array = FillArray(row, colums, min, max);
    PtintArr(Array);
}
else Console.WriteLine("Неверные данные");

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

bool IsValid(int rows,int colums)
{
	if (rows > 0 && colums > 0) return true;
	else return false;
}

int Input(string msg)
{
	Console.Write(msg);
	int a = int.Parse(Console.ReadLine());
	return a;
}

int[,] FillArray(int rows, int colums, int min, int max)
{
	int[,] arr = new int[rows, colums];
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j< arr.GetLength(1); j++)
		{
			arr[i,j] = new Random().Next(min, max);
		}
	}
	return arr;
}

void PrintArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			Console.Write(arr[i,j] + "; ");
		}
		Console.WriteLine();
	}
}


int rows = Input("Введите количество строк массива rows=");
int colums = Input("Введите количество столбцов массива colums=");
int min = Input("Введите начало диапазона min=");
int max = Input("Введите конец диапазона max =");
if (IsValid(rows, colums))
{
	int[,] Array = FillArray(rows, colums, min, max);
	PrintArray(Array);
	int row = Input("Введите номер строки row=");
	int colum = Input("Введите номер столбца colum=");
	if (row > 0 && row <= rows && colum >0 && colum <= colums) 
		Console.WriteLine("Элемент на строке " + row + ", в столбце " + colum + "=" + Array[row-1,colum-1]);
	else Console.WriteLine("Элемента с такими координатами нет");
}
else Console.WriteLine("Неверные данные");

//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

bool IsValid(int rows, int colums)
{
    if (rows > 0 && colums > 0) return true;
    else return false;
}

int Input(string msg)
{
    Console.Write(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[,] FillArray(int rows, int colums, int min, int max)
{
    int[,] arr = new int[rows, colums];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
    return arr;
}

double[] ArrayArithmeticMean(int[,] arr)
{
    double[] array = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += (double)arr[i, j];
        }
        array[j] = Math.Round(sum / arr.GetLength(0),2);
    }
    return array;
}

void PrintArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "; ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintArray1(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + "; ");
    }
    Console.WriteLine();
}

int rows = Input("Введите количество строк массива rows=");
int colums = Input("Введите количество стобцов массива colums=");
int min = Input("Введите начало диапазона min=");
int max = Input("Введите конец диапазона max=");
if (IsValid(rows, colums))
{
    int[,] Array = FillArray(rows, colums, min, max);
    double[] arithmeticMeanArray = ArrayArithmeticMean(Array);
    PrintArray2(Array);
    PrintArray1(arithmeticMeanArray);
}
else Console.WriteLine("Неверные данные");