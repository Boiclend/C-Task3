﻿
// Нужно вычислить произведение матрицы на вектор. В полученном векторе найти макисмальный элемент.

int Zapros(string message) {
 Console.WriteLine(message);
    int num = System.Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetDoubleMass(int rows, int columns) { // заполнение массива случ.числами
    int[,] arr = new int[rows,columns];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Random rnd = new Random();
            arr[i,j] = rnd.Next(1,10);


        }
    }
    return arr;
}

int[] Vector(int columns) { // заполнение вектора случ.числами
    int[] vector = new int[columns]; 
        for (int i = 0; i < columns; i++ )
        {
            Random rnd = new Random();
            vector[i] = rnd.Next(1,10);
        }
    return vector;
}

void PrintVector(int[] Vector) { // печать вектора
    Console.WriteLine("\nвектор:\n");
        for (int i = 0; i < Vector.Length; i++ )
        {
            Console.WriteLine(Vector[i]);
        }
}

void PrintArr(int[,] arr) { // печать массива
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[] ResultVector(int[,] Mass, int [] Vector) { // Произведение массива на вектор
    int[] Result = new int[Mass.GetLength(0)];
        for (int i = 0; i < Mass.GetLength(0); i++)
        {
            for (int j = 0; j < Vector.Length; j++)
            {
                Result[i] = Result[i] + Mass[i,j] * Vector[j];
            }
        Console.WriteLine();
        }
    return Result;
}

void FindMax(int[] Arr) { // поиск максимального элемента результирующего вектора
    int max = Arr[1];
    for (int i = 0; i < Arr.Length; i++)
    {
        if(Arr[i] > max) {
            max = Arr[i];
        }
    }
 Console.WriteLine($"Максимальный элемент = {max}");
}



int ROWS = Zapros("введите количество строк");
int COLUMNS = Zapros("введите количество столбцов");
if(ROWS <= 1 || COLUMNS <= 1) 
{
    Console.WriteLine("Invalid rows or columns");
    return;
}
int[,] DoubleArr = GetDoubleMass(ROWS,COLUMNS);
int[] Vectorr = Vector(COLUMNS);
PrintArr(DoubleArr);
Console.WriteLine();
PrintVector(Vectorr);
int[] OperationResult = ResultVector(DoubleArr,Vectorr);
PrintVector(OperationResult);
Console.WriteLine();
FindMax(OperationResult);