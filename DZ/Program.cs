void Zadacha63()
{
    //Задайте значение N. Напишите программу, которая выведет
    //все натуральные числа в промежутке от 1 до N.
    Console.Write("Введите натуральное число от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Натуральные числа в промежутке от 1 до {n}: ");
    Recursion(n);
    Console.WriteLine();
}

void Zadacha64()
{
    //Задайте значения M и N. Напишите программу, которая выведет все
    //натуральные числа кратные 3-ём в промежутке от M до N.

    Console.Write("Введите натуральное число от 0 до 100:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"В диапазоне от {m} до {n} кратные 3 числа: ");
    Krat2Elmnts(m, n);
    Console.WriteLine();

}

void Zadacha65()
{
    //Задайте значения M и N. Напишите программу, которая выведет
    //все натуральные числа в промежутке от M до N.
    Console.Write("Введите натуральное число от 0 до 100:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Натуральные числа в промежутке от {m} до {n}: ");
    if(m > n) 
    {
        int temp = m;
        m = n;
        n = temp;
    }
    Recursion(n, m);
    Console.WriteLine();
}

void Zadacha66()
{
    //Задайте значения M и N. Напишите программу, которая найдёт сумму
    //натуральных элементов в промежутке от M до N.

    Console.Write("Введите натуральное число от 0 до 100:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число от 0 до 100:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Сумма натуральных элементов в промежутке от {m} до {n} = {SumOfElmnts(m, n)}");
    Console.WriteLine();
}

void Zadacha67()
{
    //Напишите программу, которая будет принимать на вход число и
    //возвращать сумму его цифр.

    Console.Write("Введите натуральное число от 10 до 1000:");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(SumOfNums(num));
}

void Zadacha68()
{
    //Напишите программу вычисления функции Аккермана с помощью
    //рекурсии. Даны два неотрицательных числа m и n. 

    Console.Write("Введите натуральное число от 0 до 10:");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число от 0 до 10:");
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < 0 || n < 0) Console.WriteLine("Отрицательные числа!!!");
    else Console.WriteLine(Akkeermann(m, n));
}

void Zadacha69()
{
    //Напишите программу, которая на вход принимает два числа A и B, и
    //возводит число А в целую степень B с помощью рекурсии.
    Console.Write("Введите натуральное число от 0 до 10: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите натуральное число от 0 до 10: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Число {a} в степени {b} = {Pow(a, b)}");
}

void Recursion(int num, int count = 1)
{
    if(count > num) return;
    Console.Write(count + " ");
    count++;
    Recursion(num, count);
}

int SumOfNums(int num, int sum = 0)
{
    if (num == 0) return sum;
    sum += num % 10;
    num /= 10;
    return SumOfNums(num, sum);
}

int Pow(int a, int b, int p = 1)
{
    if(b == 0) return p;
    p *= a;
    b--;
    return Pow(a, b, p);
}

void Krat2Elmnts(int m, int n)
{
    if(m == n) return;
    if(m % 3 == 0) Console.Write(m + " ");
    m++;
    Krat2Elmnts(m, n);

}

int SumOfElmnts(int m, int n, int summ = 0)
{
    if(m > n) return summ;
    summ += m;
    m++;
    return SumOfElmnts(m, n, summ);
}

int Akkeermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return Akkeermann(m - 1, 1);
    return Akkeermann(m - 1, Akkeermann(m, n - 1));
}



//Recursion(6);
//Zadacha63();
//Zadacha64();
//Zadacha65();
//Zadacha66();
//Zadacha67();
//Zadacha68();
//Zadacha69();
