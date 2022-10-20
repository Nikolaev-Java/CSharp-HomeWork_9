/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
 */

int N;
Console.WriteLine("Введите число");
while (!int.TryParse(Console.ReadLine(), out N))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
string ForNTo1(int start, int end = 1)
{
	if (start == end)
		return "1";
	else
		return $"{start} {ForNTo1(start - 1)}";
}
Console.WriteLine(ForNTo1(N));