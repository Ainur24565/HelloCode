/* Задание №2. Напишите программу, котороя на вход принимает 
   два числа и выдает, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b)
{
    int max = a;
    Console.Write("max = ");
    Console.Write(a);
    int min = b;
    Console.Write("min = ");
    Console.Write(b);
}
else
{
    int max = b;
    Console.Write("max = ");
    Console.WriteLine(b);
    int min = a;
    Console.Write("min = ");
    Console.Write(a);
}
*/

/* Задание №4. Напишите программу, котороя на принимает на ввод
   три числа и выдает максимальное из этих чисел.
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c)
{
    int max = a;
    Console.Write("max = ");
    Console.Write(a);
}
else if (b > a && b > c)
{
    int max = b;
    Console.Write("max = ");
    Console.WriteLine(b);
}
else if (c > a && c > b)
{
    int max = c;
    Console.Write("max = ");
    Console.WriteLine(c);
}
*/

/* Задание №6. Напишите программу, котороя на ввод
   принимает число и выдает, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 2 == 0)
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}
*/

/* Задание №8. Напишите программу, котороя на ввод
   принимает число (N), а на выводе показвает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int current = 2;

while (current <= a)

{
    Console.Write(current + " ");
    current = current + 2;
}
*/