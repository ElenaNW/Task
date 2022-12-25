// Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру из этого числа. 
// 456 -> 46

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число из отрезка 100-999: {number}");

int firstDigit = number / 100;
int thirdDigit = number % 10;

Console.WriteLine($"первое число {firstDigit}");
Console.WriteLine($"третье число {thirdDigit}");

int finalDigit = firstDigit * 10 + thirdDigit;
Console.WriteLine($"двузначное число число {finalDigit}");