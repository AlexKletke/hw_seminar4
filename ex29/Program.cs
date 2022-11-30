// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

using static System.Console;
WriteLine("An array of 8 numbers will be created");

int[] fillarray()
{
    int[] array = new int[8];
    for(int i = 0; i < 8; i++)
    {
        WriteLine("enter any number: ");
        int N = int.Parse(ReadLine());
        array[i] = N;
    }
    return array;
}
int[] array = fillarray();
Write($"array received [{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}]");
