// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12



int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int A)
{
    int index = 0;
    while (A > 0)
    {
        A /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int N, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += N % 10;
        N /= 10;
    }
    Console.WriteLine(sum);
}
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);