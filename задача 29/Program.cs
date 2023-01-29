/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int[] CreateArray(string message)
{
    int[] Array = new int[8];
    for (int i = 0; i < Array.Length; i++)
    {
        int result = 0;
        while (true)
        {
            Console.WriteLine(message);

            if (int.TryParse(Console.ReadLine(), out result))
            {
                break;
            }
            else
            {
                Console.WriteLine("Ввели не число. Повторите ввод");
            }
        }
        Array[i] = result;
    }
 return Array;
}

int[] a = CreateArray("Введите число");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]} ");
    }
}
PrintArray(a);
