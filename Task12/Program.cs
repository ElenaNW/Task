// Напишите программу, которая будет принимать на вход
// 2 числа и выводить, является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа
// выводит остаток деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите 2 числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int result = number1 % number2;
if(result == 0)Console.Write("кратно");
else Console.Write($"не кратно, остаток {result}");
