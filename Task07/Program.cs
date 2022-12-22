// Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <=999)
    Console.Write($"Последняя цифра в числе {number} равна {number % 10}");
else
    Console.Write("Вы ввели не трёхзначное число"); 
