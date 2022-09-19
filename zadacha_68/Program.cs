// Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД)
//  этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7

#include <iostream>
using namespace std;
 int GCD(int a, int b)
{while (a - b != 0)
 {
   if (a > b) a -= b;
   else b -= a;
 }
return a;  
}
 
int main()
{
 
    int a, b;
    cout << "Введите два целых числа:" << endl;
    cin >> a >> b;
    cout << "НОД для 2-x введенных чисел: " << GCD(a, b) << endl;
    system("pause");
    return 0;
}