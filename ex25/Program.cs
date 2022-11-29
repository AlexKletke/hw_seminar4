// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;
double CycleDegree(int A, int B)
{
    double Result = 0;
    Result = Math.Pow(A, B);
    return Result;
}
Write("enter A: ");
int A = int.Parse(ReadLine());
Write("enter B > 0: ");
int B = int.Parse(ReadLine());
double Result = CycleDegree(A, B);
CycleDegree(A, B);
WriteLine(Result);

