// Задача 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число дня недели: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 | a == 7)
{
    Console.Write("Выходной");
}
else
{
    Console.WriteLine("Будний день");
}

//// Console.WriteLine("Print number (1-7)");
// string b = Console.ReadLine();
// if (b == "6" | b == "7") {
//   Console.WriteLine("weekend");
// }
// if (b != "6" & b != "7") {
//   Console.WriteLine("not a weeknd");
// }