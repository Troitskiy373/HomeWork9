// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

//     N = 4532 -> 4



int Recur(int n)// метод рекурсивный
{
    return n < 10 ? 1 : 1 + Recur(n / 10);
}
void Print(string[] args)// метод вывода на печать
{
    Console.Write("Введите n=");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Recur(n));
    Console.ReadKey(true);
}

Print(args);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

//     M = 1; N = 15-> 120
//     M = 4; N = 8. -> 30

Console.Clear();
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

PrintSumm(m, n, temp = 0);

void PrintSumm(int m, int n, int summ)// метод подсчета и вывода на печать
{
    summ = summ + n;
    if (n <= m)
    {
        Console.Write($"Сумма элементов= {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)// метод который принимает значения m и n
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
