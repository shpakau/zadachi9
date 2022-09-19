// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumBetweenNandM(int M, int N)
{
    if (N > M)
        return N + GetSumBetweenNandM(M, N - 1);
    return M;
}
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = GetSumBetweenNandM(M, N);
Console.WriteLine($"Сумма чисел от {M} до {N} равна {result}");