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
int threeDigitNaturNumb = 719,
    numb1,
    numb2,
    numb3,
    dozen = 10, 
    hundreds = 100,   
    reverseDigitNaturNumb;


numb1 = threeDigitNaturNumb / hundreds;
numb2 = threeDigitNaturNumb % hundreds / dozen;
numb3 = threeDigitNaturNumb % dozen;

reverseDigitNaturNumb = numb3 * hundreds + numb2 * dozen + numb1;

Console.WriteLine($"Первоначальное трёхзначное число: {threeDigitNaturNumb}, Число в обратном порядке - {reverseDigitNaturNumb}");

//Задача 3: Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
int hours = 20,
    minutes = 35,
    hoursCalc = 0,
    minutesCalc = 0,
    hoursConst = 6,
    minutesConst = 30,
    degreeMinConst,
    degreeHourConst,
    degreeMin,
    degreeHour,
    degreeAll;

degreeMinConst = 180 / minutesConst;
degreeHourConst = 180 / hoursConst;

if(minutes > minutesConst)
    minutesCalc = minutesConst - (minutes - minutesConst);

if(minutesCalc == 0)
   degreeMin = degreeMinConst;
else    
    degreeMin = degreeMinConst * minutesCalc;

if(hours > hoursConst && hours <= 12 || hours > 18)
    hoursCalc = hoursConst - (hours % hoursConst);

if(hours > 12 && hours <= 18 )
    hoursCalc = hours % hoursConst;

if(hoursCalc == 0)
    degreeHour = degreeHourConst;
else
    degreeHour = degreeHourConst * hoursCalc;

if(degreeHour > degreeMin)
    degreeAll = degreeHour - degreeMin;
else
    degreeAll = degreeMin - degreeHour;

 Console.WriteLine($"Часы: {hours}, Минуты: {minutes}, Угол: {degreeAll}");   








