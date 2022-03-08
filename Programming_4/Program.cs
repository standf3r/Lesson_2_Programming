// Задача 14. Найти третью цифру числа или сообщить, что её нет

//Даннную задачу решил только для трехзначного числа. Если ввести число больше трех знаков, то он будет показывать последнюю цифру числа.

Console.WriteLine("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = (a % 10);
int c = (a % 100);
int d = (a % 100);
if (a >= 100)
{
    Console.Write($"Третье число равно: {b}");
}
else
{
    Console.WriteLine("Третьего числа не существует");
}


// Console.WriteLine("Введите число: ");
// string a = Console.ReadLine();
// a = a.Remove(a.IndexOf("-"),1);
// if (a.Length>2)
// {
//     a=a.Substring(2,1);
// }
// else 
// {
//     Console.Write("Третьего числа не существует");
// }