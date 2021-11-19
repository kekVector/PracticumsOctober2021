// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D



// 15. Дано число. Проверить кратно ли оно 7 и 23

// int n = 161;
// int a = 7, b = 23;
// bool res15(int num, int a, int b)
// {
//     return (num%a == 0 ) && (num%b == 0); 
// }
// Console.WriteLine($"Число {n} {(res15(n, a, b) ? "кратно" : "не кратно")} чилам {a} и {b}");




// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 

// int WeekDay = int.Parse(Console.ReadLine());

// bool weekendDay(int num)
// {
//     return (num == 7) || (num == 6);
// }
// Console.WriteLine($"Текущий день недели {(weekendDay(WeekDay) ? "выходной" : "не выходной")}");






// 17. По двум заданным числам проверять является ли одно квадратом другого

// int num1 = 4, num2 = 16;

// bool IsPow(int a, int b)
// {
//     return (a == b*b) || (b == a*a);
// }
// Console.WriteLine($"Одно из чисел {num1} {num2} {(IsPow(num1, num2) ? "является" : "не является")} квадратом второго  ");
// Console.WriteLine($"Одно из чисел {num1} {num2} {(IsPow(num2, num1) ? "является" : "не является")} квадратом второго  ");


// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool result18(bool X, bool Y)
{
    return (!(X || Y)) == (!X && !Y);
}

// Console.WriteLine(result18(true, true));
// Console.WriteLine(result18(false, true));
// Console.WriteLine(result18(true, false));
// Console.WriteLine(result18(false, false));

// bool ConvertToBool(int a)
// {
//     return a == 1;
// }

// for(int i = 0; i<=1; i ++)
// {
//     for(int j = 0; j <= 1; j++)
//     Console.WriteLine(result18(ConvertToBool(i), ConvertToBool(j)));
// }

// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

// int a1 = 1, a2 = 1;
// int b1 = -1, b2 = 1;
// int c1 = 1, c2 = -1;
// int d1 = -1, d2 = -1;

// int NumberChetv(int a, int b)
// {
//     if (a > 0 && b > 0) return 1;
//     if (a < 0 && b > 0) return 2;
//     if (a < 0 && b < 0) return 3;
//     else return 4;
// }
// Console.WriteLine($"Номер четверти координат {a1} и {a2} - {NumberChetv(a1, a2)} ");
// Console.WriteLine($"Номер четверти координат {b1} и {b2} - {NumberChetv(b1, b2)} ");
// Console.WriteLine($"Номер четверти координат {c1} и {c2} - {NumberChetv(c1, c2)} ");
// Console.WriteLine($"Номер четверти координат {d1} и {d2} - {NumberChetv(d1, d2)} ");



// 20. Задать номер четверти, показать диапазоны для возможных координат


// string[] Koordinati(int NumCh)
// {
//     return (NumCh == 1) ?  new string[]{"(0;+∞)","(0;+∞)"} : ( (NumCh == 2 ? new string[]{"(-∞;0)","(0;+∞)"} : ( (NumCh == 3 ? new string[]{"(-∞;0)","(-∞;0)"} : new string[]{"(0;+∞)","(-∞;0)"}))));

// }

// int a = 2;
// string[] diapozon = Koordinati(a);

// Console.WriteLine($"х = {diapozon[0]}, y = {diapozon[1]}");




// 21. Программа проверяет пятизначное число на палиндромом.

// int Num = 51615;

// bool result21(int a)
// {
//     int[] array = new int[5];
//     int b = a;
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = b % 10;
//         b = b / 10;
//     }
//     for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
//     return (array[0] == array[4]) && (array[1] == array[3]);
// }
// bool result21Second(int a)
// {
//     string array = Convert.ToString(a);    
//     return (array[0] == array[4]) && (array[1] == array[3]);
// }
// bool L1 = result21(Num);
// bool L2 = result21Second(Num);
// Console.WriteLine($"Число {Num} - {(L1 ? "палиндром" : "не палиндром")}");



// 22. Найти расстояние между точками в пространстве 2D/3D