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
    dozen = 10, 
    hundreds = 100;

Console.WriteLine($"Первоначальное трёхзначное число: {threeDigitNaturNumb}");

threeDigitNaturNumb =   (threeDigitNaturNumb % dozen * hundreds) 
                        + (threeDigitNaturNumb / dozen % dozen * dozen) 
                        + (threeDigitNaturNumb / hundreds);

Console.WriteLine($"Число в обратном порядке - {threeDigitNaturNumb}");

//Задача 3: Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
int     hours = 12,
        minutes = 15;             
                
double  degreeHour,
        degreeHourConst,
        degreeAll,
        minutesConst = 60,
        hoursConst = 12,
        degreeMinConst,
        degreeMin;

degreeMinConst = 360 / minutesConst;
degreeMin = (minutes % 60) * degreeMinConst;

degreeHourConst = 360 / hoursConst;
degreeHour =  (hours % 12) * degreeHourConst 
            + (minutes / minutesConst) * degreeHourConst; //осуществляя деление заданных минут на общее количество минут в часе, 
                                                          //получаем часть пройденного пути часовой стрелки за указанное время
                                                          //далее умножаем на часовой градус, чтобы получить дополнительный градус к пройденному пути часовой стрелки с учётом пройденных минут

degreeAll = Math.Abs(degreeHour - degreeMin);
degreeAll = Math.Min(degreeAll, 360 - degreeAll);

Console.WriteLine($"Часы: {hours}, Минуты: {minutes}, Угол: {degreeAll}");   

//Задача 4: Найти количество чисел меньших N, которые имеют простые делители X или Y.

int numb = 10, //2,3,4,6,8,9
    x    = 2,
    y    = 3; 






