//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
Console.WriteLine("Введите число: ");
string num_1 = Console.ReadLine();
if ((Convert.ToInt32(num_1) % 2) == 0)
    Console.Write($"{num_1} - четное число");
else
    Console.Write($"{num_1} - нечетное число");