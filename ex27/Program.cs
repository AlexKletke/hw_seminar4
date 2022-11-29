// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
using static System.Console;

Write("enter Number > 0: ");
// НЕ ПОЛУЧИЛОСЬ через string:
//string Number = ReadLine();
//int size = Number.Length;
//int SUM = 0;
//for(int i = 0; i < size; i++)
//{
//    SUM = SUM + Number[i];
//}

int SumDigits (int N)
{
    int SUM = 0;
    while(N > 0)
    {
        SUM = SUM + N%10;
        N = N/10;
    }
    return SUM;
}
int N = int.Parse(ReadLine());
int SUM = SumDigits (N);
WriteLine($"the sum of the digits of the number: {SUM}");


