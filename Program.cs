//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Power (int number, int degree){
    
    int result = 1;
    for (int i = 0; i < degree; i++)
    {
        result *= number;
    }
    return result;
}

Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a degree for the number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{num1} powered by {num2} is {Power(num1, num2)}");*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Sum (int number){

    int result = 0;

  while (number > 0)
  {
    int digit = number%10;
    result += digit;
    number = number/10;

    
  }
  return result;
}
Console.Write("Input a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of the digits of {num1} is {Sum(num1)}");*/

//Задача 29: Напишите программу, которая ненерирует массив из m элементов, заданный пользователем и выводит их на экран.

int[] GetArray (int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
    Console.Write($"Input element {(i+1)} for your array: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}


Console.Write("Input a size for array: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] myArray = GetArray(number);
ShowArray(myArray); 

/*
void ShowArray(int[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}
*/
void ShowArray(double[]array){

    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

        Console.WriteLine();
}


//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateThreeDigitsArray(int size){

    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(100, 1000);
    
    return array;
}
int EvenCountArray(int[] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}
Console.Write("Input size of the array: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateThreeDigitsArray(number);
ShowArray(myArray);
Console.WriteLine("Number of even digits in your array is " + EvenCountArray(myArray)); */

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях (index).
/*
int[] CreateArray(int size, int min, int max){
    int[] array = new int[size];
    for (int i = 0; i < size; i++)    
        array[i] = new Random().Next(min, max);
    
    return array;
    
}
int SumOddIndexArray(int[] array){
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+= array[i];
    }    
        
    return sum;
}
Console.Write("Input size of the array: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(number, minValue,maxValue);
ShowArray(myArray);
Console.WriteLine("Sum for numbers with odd index is: " + SumOddIndexArray(myArray)); 
*/
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

    double[] CreateArray(int size, int min, int max){

    double[] array = new double[size];

    for (int i = 0; i < size; i++)    
        array[i] = Math.Round((new Random().NextDouble()), 2) + new Random().Next(min, max);
    
    return array;
    
}

double MinMaxDifference (double[] array){
   
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        
        if (array[i] > max)
            max = array[i];
    }

     double dif = max - min;
     return dif;
}

Console.Write("Input size of the array: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min value of the array: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max value of the array: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateArray(number, minValue, maxValue);
ShowArray(myArray);

Console.WriteLine("The difference between max and min value of the array is: " + MinMaxDifference(myArray));
<Project Sdk="Microsoft.NET.Sdk">

  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net6.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

</Project>
 40  
Homework6/Program.cs
@@ -0,0 +1,40 @@
//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Input amount of the digits: ");
int amount = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < amount; i++)
{
    Console.WriteLine("Input a digit number " + (i+1));
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
}
Console.WriteLine("Number of digit above 0 is " + count);
*/

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void LineCross(double k1, double b1, double k2, double b2){

    if(k1 == k2) Console.WriteLine("The lines are parallel");
    if (k1 == k2 && b1 == b2) Console.WriteLine("The lines are equal");
    if (k1 != k2 && b1 == b2) Console.WriteLine($"The intersection coordinates are ({0}; {b1})");
    else
    {
        double x = (b1 - b2) / (k2 - k1);
        double y = k1 * x + b1;
        Console.WriteLine($"The intersection coordinates are ({x}; {y})");
    }   
}

Console.Write("Input the first coefficient of the first line ");
double coef1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coefficient of the first line ");
double coef2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the first coefficient of the second line ");
double coef3 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input the second coefficient of the second line ");
double coef4 = Convert.ToDouble(Console.ReadLine());

LineCross(coef1,coef2,coef3,coef4);
//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateDouble2DArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round((new Random().NextDouble()), 2) + new Random().Next(minValue, maxValue);

    return array;
}

void ShowDouble2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

void FindArrayElement(double[,] array, int rowIndex, int colIndex)
{
    if (rowIndex < array.GetLength(0) && colIndex < array.GetLength(1))
        Console.WriteLine(array[rowIndex, colIndex]);
    else
        Console.WriteLine("There is no element with such index");
}

//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int [,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue);

    return array;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

double[] ArrayColumnAverage(int [,] array)
{
    double[] arrayAverage = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
            sum += array[j, i];

        arrayAverage[i] = Math.Round(sum / array.GetLength(0), 2);
    }
        
        return arrayAverage;  
}

void ShowArray(double[] array){
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

Console.Write("Input the number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the array max value: ");
int max = Convert.ToInt32(Console.ReadLine());

// double[,] myArray = CreateDouble2DArray(numX, numY, min, max);
// ShowDouble2DArray(myArray);

// Console.Write("Please, input the row index of the element: ");
// int xPosition = Convert.ToInt32(Console.ReadLine());
// Console.Write("Please, input the column index of the element: ");
// int yPosition = Convert.ToInt32(Console.ReadLine());
// FindArrayElement(myArray, xPosition, yPosition);


int [,] myArray = Create2DArray(numX, numY, min, max);
Show2DArray(myArray);

double[] myAverageArray = ArrayColumnAverage(myArray);
ShowArray(myAverageArray);