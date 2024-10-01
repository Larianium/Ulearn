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
//Решение описывает более сложный вариант задачи, где угол высчитывается относительно минутной и часовой стрелки при при любом их значении, так же учитувает угол сдвига 
//часовой стрелки, когда минутная не равна 0 минут (в зачаде минутная стрелка всегда равна нулю, условие более простое)
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
    x    = 3, 
    y    = 2; 

    // Находим количество чисел, кратных X, Y, и их общему кратному (LCM)
    int countX = (numb - 1) / x; 
    int countY = (numb - 1) / y; 
    int countXY = (numb - 1) / LCM(x, y);  // Числа кратные одновременно X и Y

    // Общий результат: кратные X или Y, с учетом общих кратных
    int result = countX + countY - countXY;

    Console.WriteLine($"Количество чисел, меньших {numb}, которые делятся на {x} или {y}: {result}");

    Console.WriteLine($"НОД: {GCD( x,  y)}");   
    Console.WriteLine($"НОК: {LCM( x,  y)}");   

    // Метод для нахождения наименьшего общего кратного (LCM)
    static int LCM(int a, int b)
    {
        return a * b / GCD(a, b);  // LCM(X, Y) = X * Y / GCD(X, Y)
    }

    // Метод для нахождения наибольшего общего делителя (GCD)
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

// Задача 5: Найти количество високосных лет на отрезке [a, b] не используя циклы.
//1. Учесть, что високосные годы кратны 4, но при этом годы, кратные 100, не являются високосными, за исключением тех, что кратны 400.
//2. Найти количество високосных лет от 0 до a-1 и от 0 до b, чтобы найти количество високосных лет между a и b как разность этих двух значений

int a = 1995,
    b = 2032,
    count;

count = CountLeapYears(b) - CountLeapYears(a - 1);

static int CountLeapYears(int year)
{
    return (year / 4)  // Считает количество лет, кратных 4 (все потенциальные високосные годы)
           - (year / 100) // Убирает годы, кратные 100, которые не являются високосными
           + (year / 400); // Возвращает годы, кратные 400, которые являются високосными, так как их нужно добавить обратно
}

Console.WriteLine($"Количество високосных годов в периоде: {count}"); 



