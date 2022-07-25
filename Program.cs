// Задача 47

/*double[,] RandomeDoubleArr(int rows, int colums, int minRan, int maxRan)
{
    double[,] newArray = new double[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            newArray[i, j] = Convert.ToDouble(new Random().Next(minRan, maxRan)) / 10;
    return newArray;
}
void ShowDoubleArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] myArray = RandomeDoubleArr(m, n, min, max);
ShowDoubleArray(myArray); */

// Задача 50

/* int[,] Random2dArr(int rows, int columns, int minRan, int maxRan)
{
    int[,] newArr = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArr[i,j] = new Random().Next(minRan, maxRan + 1);

    return newArr;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void Element(int[,] array)
{
    Console.WriteLine("Введите номер строки разыскиваемого элемента: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца разыскиваемого элемента: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m > array.GetLength(0) || n > array.GetLength(1))
    {
        Console.WriteLine("Указанный индекс элемента выходит за границы существующего массива");
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine($"Элемент, находящийся в строке {m} и столбце {n} = {array[m - 1, n - 1]}");
    }

}


Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Random2dArr(m, n, min, max);
Console.WriteLine();
Show2dArray(myArray);
Console.WriteLine();
Element(myArray); */

// Задача 52

/* int[,] Random2dArr(int rows, int columns, int minRan, int maxRan)
{
    int[,] newArr = new int[rows,columns];

    for (int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArr[i,j] = new Random().Next(minRan, maxRan + 1);

    return newArr;
}

void Show2dArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void medium(int[,] array, int m)
{
    double summ = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {        
        for (int i = 0; i < array.GetLength(0); i++)
            summ = (summ + array[i, j]);        
        summ =  summ / m;
        Console.Write(summ + "; ");
    }
}


Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение числа для массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение числа для массива: ");
int max = Convert.ToInt32(Console.ReadLine());


int[,] myArray = Random2dArr(m, n, min, max);
Console.WriteLine();
Show2dArrayInt(myArray);
Console.WriteLine();
Console.WriteLine("Среднее арифметическое значение по столбцам: ");
medium(myArray, m); */


