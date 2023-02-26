//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// создали

int[] RandomArray(int size, int a, int b)
{

    int[] RandomArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(a, b + 1);
    }
    return RandomArray;
}

// печать

void printArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(Convert.ToString(arr[i]));
    }
}

//количество чётных чисел в массиве

int EvenNumbers(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
        if (array1[i] % 2 == 0)
        {
            count = count + 1;
        }
    return count;
}

int[] myArray = new int[1];
myArray = RandomArray(4, 100, 999);
printArray(myArray);
Console.WriteLine("количество четных чисел в массиве " + EvenNumbers(myArray));



//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


//создали массив
int[] CreateArray(int length)
{
    return new int[length];
}
//распечатали
void Print(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}
int[] arr = CreateArray(4);

// заполнили
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 5);
        index++;
    }
}
//сумма элементов

int SummOddPositions(int[] arr)
{
    int result = 0;
    for (int index = 0; index < arr.Length; index++)

        if (index % 2 != 0)
            result += arr[index];

    return result;
}
//печать результата

void PrintingFinalResult(int result)
{
    Console.WriteLine($"сумма нечетных позиций  {result}");
}

FillArray(arr);
Print(arr);
Console.WriteLine();
int result = SummOddPositions(arr);
PrintingFinalResult(result);


//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// создать и распечатать

void PrintArray1(double[] arr)
{
    for (int index = 0; index < arr.Length; index++)
    {
        Console.Write(arr[index] + " ");
    }
    Console.WriteLine();
}

double[] array = new double[5] { 3, 7, 22, 2, 78 };

PrintArray1(array);

//максимальный элемент

double Maximum(double[] arr)
{

    double max = arr[0];

    for (int index = 0; index < arr.Length; index++)
    {
        if (max < arr[index])
        {
            max = arr[index];
        }
    }

    return max;
}
double max = Maximum(array);

// минимальный элемент

double Minimum(double[] arr)
{

    double min = arr[0];

    for (int index = 0; index < arr.Length; index++)
    {
        if (min > arr[index])
        {
            min = arr[index];
        }
    }

    return min;
}
double min = Minimum(array);

//разница

double Difference(double min, double max)
{
    double Result = max - min;

    return Result;
}
double Result = Difference(min, max);

//печать результата

void PrintingFinalResult1(double Result)
{
    Console.WriteLine($"Разница между максимальным и минимальным элементом равна  {Result}");
}
PrintingFinalResult1(Result);
