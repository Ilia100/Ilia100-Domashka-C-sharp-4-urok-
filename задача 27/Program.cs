/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
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

    return Math.Abs(result);
}

int GetLong(int num)
{
    string GetText = num.ToString();
    int longText = GetText.Length;
    return longText;
}

void Getsum(int numb, int Length)
{
    int result = 0;
    int temp =numb;

    for (int i = 1; i <= Length; i++)
    {
        
        result = result + (temp%(10));
        temp=temp/10;
    }

    Console.WriteLine($"сумма цифр: {result}");
}

int number = GetNumber("Введите любое число");
int l = GetLong(number);
Getsum(number, l); 
