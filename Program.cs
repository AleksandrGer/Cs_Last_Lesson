// Задача 64: Задайте значения M и N.
// Напишите программу, которая выведет все
// натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if(start == end) return start.ToString();
//     return (start + "\t" + PrintNumbers(start + 1, end));
// }
// Console.WriteLine(PrintNumbers(M, N));

// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int GetSum(int first, int last)
// {
//     int sum = first;
//     if(first == last) return sum;
//     else return sum + GetSum(first + 1, last);
// }
// Console.WriteLine(GetSum(M, N));

// Задача 68: Напишите программу вычисления
// функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// int m = 0;
// int n = 3;

// int Acker(int first, int second)
// {
//     while(m > 0 && n > 0)
//     {
//     if(n == 0) return m + 1;
//     if(m == 0) return Acker(n - 1, 1);
//     else return Acker(n - 1, Acker(n, m - 1));
//     }
// }
// Console.WriteLine(Acker(m, n));