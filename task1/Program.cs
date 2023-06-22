// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int number1 = ReadInt("Введите число A: ");
int number2 = ReadInt("Введите число B: ");
{
    System.Console.WriteLine(Math.Pow(number1, number2) + " ");
}