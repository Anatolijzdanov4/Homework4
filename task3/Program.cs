// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int ReadInt(string text)
{
    System.Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}


void FillArray(int[] array) 
{
    Random rand = new Random();
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = rand.Next(0, 9);
    }
}
void PrintArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        System.Console.Write(array[index] + " ");
    }
}
int i = ReadInt("Введите число: ");
int[] array = new int[i];
FillArray(array);
PrintArray(array);
