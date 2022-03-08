// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// Аналогично первой задачи, только вместо введеного значения вставляем случайное

string a = Convert.ToString(new Random().Next(10,1000));
Console.WriteLine(a);
int b = a.Length - 1;
a = a.Remove(b); 
a = a.Remove(0, 1);
Console.WriteLine(a); 