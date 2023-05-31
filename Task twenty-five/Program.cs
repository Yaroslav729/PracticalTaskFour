// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите степень: ");
int count = 1;
int b = int.Parse(Console.ReadLine()!);
for (int i = 0; i < b; i++){
count *= a;
}


Console.Write($" {count} ");