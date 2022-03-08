// Дано число. Проверить кратно ли оно 7 и 23

// Решил с помощью деления. Указал два условия, сначала для 7, потом для 23. Решение примерно как с Homework 3. 

Console.Write("Введите число: ");
int a  = Convert.ToInt32(Console.ReadLine());
int c = (a % 7);
int d = (a / 7);
if (a%7==0)
{
    Console.WriteLine($"Число кратно 7, равен: {d}");
}
else
{
    Console.WriteLine($"Заданное число не кратно 7, остаток равен: {c}");
}

int e = (a % 23);
int f = (a / 23);
if (a%23==0)
{
    Console.WriteLine($"Число кратно 23, равен: {f}");
}
else
{
    Console.WriteLine($"Заданное число не кратно 23, остаток равен: {e}");
}

