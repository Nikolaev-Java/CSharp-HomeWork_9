/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */
int m, n;
Console.WriteLine("Введите первое число");
while (!int.TryParse(Console.ReadLine(), out m))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
Console.WriteLine("Введите второе число");
while (!int.TryParse(Console.ReadLine(), out n))
{
	Console.WriteLine("Не верный ввод. Повторите ввод");
}
int AkkermanFunction(int _m, int _n)
{
	if (_m == 0)
		return ++_n;
	else if (_m > 0 && _n == 0)
		return AkkermanFunction(_m - 1, 1);
	else if (_m > 0 && _n > 0)
		return AkkermanFunction(_m - 1, AkkermanFunction(_m, _n - 1));
	return 0;
}
Console.WriteLine($"Результат функции Аккермана = {AkkermanFunction(m, n)}");