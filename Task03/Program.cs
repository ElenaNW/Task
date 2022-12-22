/*Напишите программу, котороая будет выдавать
название дня недели по заданному номеру.
3 -> Среда
5 -> Пятница*/

Console.WriteLine("Введите номер дня недели от 1 до 7");
string a = Console.ReadLine();
if (a == "1") ; Console.WriteLine("Понедельник");
if (a == "2") ; Console.WriteLine("Вторник");
if (a == "3") ; Console.WriteLine("Среда");
if (a == "4") ; Console.WriteLine("Четверг");
if (a == "5") ; Console.WriteLine("Пятница");
if (a == "6") ; Console.WriteLine("Суббота");
if (a == "7") ; Console.WriteLine("Воскресенье");
else Console.WriteLine("Неверные данные");