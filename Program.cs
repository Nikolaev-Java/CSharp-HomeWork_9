/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
int a, b;
Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out a))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out b))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
if (a > b)
{
	int temp = a;
	a = b;
	b = temp;
}
int Sum(int start, int end)
{
	int sum = start;
	if (start == end)
		return end;
	else
		return sum += Sum(start + 1, end);
}
Console.WriteLine($"Сумма от {a} до {b} равна {Sum(a, b)}");