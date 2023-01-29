/* 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int GetNumber(string message)
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

    return result;
}

int Getpow(int num1, int num2)
{
    int result = 1;

    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }

    return result;
}

int number1 = GetNumber("Введите первое число");
int number2 = GetNumber("Введите второе число");

int pow = Getpow(number1, number2);
Console.WriteLine($"{number1} в степени {number2} = {pow}");
