// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void GetWriteArray (int[] arrayNum)
{
    Console.Write($"[");

    for (int i = 0; i < arrayNum.Length; i++)
    {
      Console.Write($"{arrayNum[i]} "); 
    }

    Console.Write($"]");
}

int[] GetRandome (int[] arrayNumber, int numStart, int numEnd)
{
    for (int i = 0; i < arrayNumber.Length; i++)
    {
      arrayNumber[i] = new Random().Next(numStart, numEnd+1);  
    }
    return arrayNumber;
}

Console.WriteLine("Введите начальное число диапозона для заполнения массива NumberStart:");
int NumberStart = int.Parse(Console.ReadLine());

Console.WriteLine("Введите конечное число диапозона для заполнения массива NumberEnd:");
int NumberEnd = int.Parse(Console.ReadLine());

int [] array = new int[8];
int[] myarray = GetRandome(array, NumberStart, NumberEnd);

GetWriteArray(myarray);
