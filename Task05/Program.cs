// Напишите программу, которая на ввод
//принимает одно число (N), а на выходе показывает 
//все целые числа от -N до N
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = -number;
while (count <= number)
{
    Console.Write(count + " ");
    count++;
}
