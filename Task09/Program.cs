// Напишите программу, которая выводит
// случайное число из отрезка [10,99]
// и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка 10-99 -> {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if (firstDigit > secondDigit) Console.WriteLine($"Наибольшая цифра числа = {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа = {secondDigit}");

//int result = firstDigit > secondDigit ? firstDigit : secondDigit;
//Console.WriteLine($"Наибольшая цифра числа: {result}");

int maxDigit = MaxDigit(number);
Console.WriteLine($"Наибольшая цифра числа: {maxDigit}");


int MaxDigit(int num) //num = number
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    return firstDigit > secondDigit ? firstDigit : secondDigit;
}
