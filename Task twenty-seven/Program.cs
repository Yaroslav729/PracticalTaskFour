// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
int len = CountLenght(a);
int counter = 0;
int CountLenght(int num)
{
int index = 0;
while(num > 0)
{
num /= 10;
index++;
}
return index;
}
for(int i = 0; i < len; i++){
counter += a % 10;
           a /= 10;
}
Console.Write(counter); 