// Выяснить, кратно ли часло заданному, если нет, вывести остаток


Console.Write("Введите первое число: ");
int a  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b  = Convert.ToInt32(Console.ReadLine());
int c = (a % b);
int d = (a / b);
if (a%b==0)
{
    Console.WriteLine($"Число кратно заданному, без остатка равен: {d}");
}
else
{
    Console.WriteLine($"Заданное число делится с остатком, остаток равен: {c}");
}

