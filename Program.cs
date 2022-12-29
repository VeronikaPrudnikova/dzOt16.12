// Создать массив из 12 эллементов. Заполненными случайными числами. От промежутка от -9 до 9. Найдите сумму - элемента массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

int GetSumOfNegatives(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i]; //sum + array[i];
    }
    return sum;
}


Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements max: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = GetSumOfNegatives(myArray);
Console.WriteLine("Sum of negative elements is" + result);
*/

// Напишите программу замены элементов массива. Положительные елементы замените на соотвествующие отрицательные, а отрицательные наоборот.

// Необходимо задать одномерный массив из м случайных чисел и найти количество элементов массива, которые лежат в отрезки от А до Б.

//  Необходимо найти произведение пару числе в одномерном массиве. 2332 4и 6. 
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

int[] revers(int[] array)
{
    int works = - 1;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) works *= array[i]; 
    }
    return array;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] result = revers(myArray);
ShowArray(result);
*/
/*
int[] CreateRandomArray(int size, int AValue, int BValue)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(AValue, BValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

int Mult (int[] array, int A, int B)
{
    int count= 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= A || array[i] <=  B)
        {
            count++;
        }
    }
    return count;
}



Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements min: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements max: ");
int B = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, A, B);
ShowArray(myArray);

int result = Mult(myArray, A, B);
Console.WriteLine(result);
*/
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}

int[] MultPairs(int[] array)
{
    int size = array.Length/ 2;
    if(array.Length % 2 != 0)  size++;
    
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
       newArray[i] =array[i] * array[array.Length -1 - i];
    }
    return newArray;

}


Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] result = MultPairs(myArray);
ShowArray(result);
*/
// Напишите программу. которая перевернет одномерный массив. 

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}


void ReverArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

ReverArray(myArray);
ShowArray(myArray); 
*/
//Необходимо написать программу, которая принимает навход 3 числа и проверяет может ли существовать треугольник с такими длины.
 /*
bool IsTrilongle(int first, int secound, int third)
{
    if(first > secound + third && secound > first + third && third > secound + first)
    return false;
    else return true;
}

Console.Write("Пожалуйста введите длину первой стороны: ");
int first = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите длину второй стороны: ");
int secound = Convert.ToInt32(Console.ReadLine());

Console.Write("Пожалуйста введите длину третьей стороны: ");
int third = Convert.ToInt32(Console.ReadLine());

bool result = IsTrilongle(first, secound, third);
string answer = result == true? "IsTriLongle can be": "IsTriLongle cannot be";
Console.WriteLine(answer);
*/

// необходимо вывести первое N типо начо первые два числа это А и Б. 
/*
void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
        if(i == array.Length - 1) Console.WriteLine("]");
        else Console.Write(", "); 
    }
}

int[] Fibonacci(int a, int b, int size)
{
    int[] fibArray = new int[size];
    fibArray[0] = a;
    fibArray[1] = b;
    for(int i = 0; i < size; i++)
    {
        fibArray[i] = fibArray[i-1] + fibArray[i-2];
    }
    return fibArray;
}
bool IsTrilongle(int first, int secound, int third)
{
    if(first > secound + third && secound > first + third && third > secound + first)
    return false;
    else return true;
}

Console.Write("Please, enter size: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter secound value: ");
int secound = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter first value: ");
int first = Convert.ToInt32(Console.ReadLine());
bool result = IsTrilongle(first, secound, size);
string answer = result == true? "IsTriLongle can be": "IsTriLongle cannot be";
Console.WriteLine(answer);
int[] myArray = Fibonacci(first, secound, size);
ShowArray(myArray); 
*/
//Написать программу которая будет создавть копию поэлементного копирования. 
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[]array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        Console.WriteLine($"array[{i + 1}] is {array[i]}");
    }
}
int[] CoryArray (int[] array)
{
    int[] copyArray = new int[array.Length];
    for(int i = 0; i < array.Length; i++)
        copyArray[i] = array[i];
    return copyArray;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements min: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number of elements max: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size, min, max);
int [] copyArray = CoryArray(myArray);
ShowArray(myArray);
ShowArray(copyArray);

*/

// Напишите программу, которая  будет преобразовывать десятичное число в двоичное.
/*
string DecToBin (int number)
{
    string bin = String.Empty;
    while(number > 0)
    {
        bin = number%2 + bin;
        number /= 2;
    }
    return bin;
}


Console.WriteLine("Please, enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

String result = DecToBin(number);
Console.Write(result);

*/

/*
 string text ="(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "")
                ;

 var data = text.Split(" ")
                .Select(item => item.Split(','))
                .Select(e => (x: int.Parse(e[0]), int.Parse(e[1])))
                .ToArray();
for(int i =0; i < data.Lenght; i++)
{
    Console.WriteLine(data[i].x*10);
    Console.WriteLine();
}
*/

//20.12.22  Задайте двумерный массив случайными рандомными целыми числа М на N
/*
int[,] CreateRandom2DArray()  //первое указываем кол.во строк, затем стобцы, нахождение элемента
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of elements Value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input a number of elements Value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns;] //объявление массива
    for(int i = 0; i < rows; i++)          //будем использовать вложенный цикл, который будет переводить из строки к строке. А будет внешний цикл.Начинаем с внешнего цикла. 
    {
        for(int j = 0; j < columns; j++)  //что будет происходить в каждой строке. обращаемся к номеру  столбца.
        
            array[i,j] = new Random(). Next(minValue, maxValue +1);
        return array;
    }  

}

void Show2dArray(int[,] array)
{
    for(int i =0; i < array.GetLenght(0); i++)
    {
        for(int j = 0; j < array.GetLenght(1); j++)
        Console.Write(array[i,j]+ " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}



int[,] myArray = CreateRandom2DArray();
Show2dArray(myArray);
*/