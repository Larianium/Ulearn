// See https://aka.ms/new-console-template for more information

//Задача 1: Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
int value_1 = 10020;
int value_2 = 15000;

Console.WriteLine($"До: Значение 1 - {value_1}, Значение 2 - {value_2}");

value_2 = value_2 - value_1;

value_1 = value_2 + value_1;
value_2 = value_1 - value_2;

Console.WriteLine($"После: Значение 1 - {value_1}, Значение 2 - {value_2}");

//Задача 2: Задается натуральное трехзначное число (гарантируется, что трехзначное). Развернуть его, т.е. получить трехзначное число, записанное теми же цифрами в обратном порядке.
int threeDigitNaturNumb;




