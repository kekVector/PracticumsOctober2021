// Почувствуй себя интерном
//  0. Вывести квадрат числа
//  1. По двум заданным числам проверять является ли первое квадратом второго
//  2. Даны два числа. Показать большее и меньшее число
//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y = f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет



// Задача 0. 
// Вывести квадрат числа 

// int a = int.Parse(Console.ReadLine());

// int Kvadrat(int a)
// {
//     return a*a;
// }
// Console.WriteLine($"Квадрат числа {Kvadrat(a)}");





// Задача 1. 
//По двум заданным числам проверять является ли первое квадратом второго

// int a = 64;
// int b = 4;
// bool Kvd(int a1, int a2)
// {
//    return a1 == a2*a2;
// }
// bool result1 = Kvd(a,b);
// Console.WriteLine($" число {a} {(result1 ? "является" : "не является")} квадратом {b}");
// Console.WriteLine($" число {64} {(Kvd(64, 8) ? "является" : "не является")} квадратом {8}");





// Задача 2. 
// Даны два числа. Показать большее и меньшее число

// int num1 = 211;
// int num2 = 35;
// int[] more(int a, int b)
// {
//     if (a < b) return new int[] { a, b };
//     else return new int[] { b, a };


// }
// int[] answer = more(num1, num2);
// Console.WriteLine($"{answer[0]} < {answer[1]}");
// answer = more(20, 4);
// Console.WriteLine($"{answer[0]} < {answer[1]}");




//Задача 3. 
//По заданному номеру дня недели вывести его название

// int NumberWeek = int.Parse(Console.ReadLine());

// string Week(int date)
// {
//     if (date == 1)
//     {
//         return "понедельник";
//     }
//     else if (date == 2)
//     {
//         return "вторник";
//     }
//     else if (date == 3)
//     {
//         return "среда";
//     }
//     else if (date == 4)
//     {
//         return "четверг";
//     }
//     else if (date == 5)
//     {
//         return "пятница";
//     }
//     else if (date == 6)
//     {
//         return "суббота";
//     }
//     else
//     {
//         return "воскресенье";
//     }


// }
// if (NumberWeek > 0 && NumberWeek < 7)

//     Console.WriteLine($"Сегодня {Week(NumberWeek)}");
// else
// {
//     Console.WriteLine("Такого дня нет");
// }



//Задача 4. 
//Найти максимальное из трех чисел 
// int N = 3;
// int[] CreateArray(int N)
// {
//     return new int[N];
// }

// int[] FillArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(1, 99);
//         Console.Write(arr[i] + " ");
//     }
//     Console.WriteLine(" ");
//     return arr;
// }



// int maxi(int[] array)
// {
//     int max = array[0];
//     for (int i = 1; i < array.Length; i++)
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     return max;
// }

// Console.WriteLine("максимальный элемент: " + maxi(FillArray(CreateArray(N))));






//Задача 5. 
// Написать программу вычисления значения функции y=sin(a) 
// double GetF(double a)
// {
//     return Math.Sin(a);
// }
// Console.WriteLine(GetF(6));





//Задача 6.
//Выяснить является ли число чётным
// int Number = new Random().Next(1,100);

// bool chet(int N)
// {
//     if(N%2 == 0) return true;    
//     else return false;
// }
// bool ch = chet(Number);
// if(ch)Console.WriteLine($"Число {Number} четное");
// else Console.WriteLine($"Число {Number} нечетное");



//Задача 7. 
// Показать числа от -N до N 

// int num = int.Parse(Console.ReadLine());
// void PrintFromMinus(int a)
// {

//     for (int index = a * -1; index <= a; index++)
//     {
//         Console.Write(index + " ");
//     }
// }
// PrintFromMinus(num);





// Задача 8.
// Показать четные числа от 1 до N

// Console.WriteLine("Введите число : ");

// int a = int.Parse(Console.ReadLine());

// void chet(int Num)
// {
//     for(int i=2; i<= Num; i+=2)
//     {
//         Console.Write(" " + i);
//     }
// }
// chet(a);


//  9. Показать последнюю цифру трёхзначного числа
// int Num = 123;

// int LustNumFromThree(int n)
// {
//     return n%10;
// }
// Console.WriteLine($"Последняя цифра числа {Num} - {LustNumFromThree(Num)}");






// 10. Показать вторую цифру трёхзначного числа
// int Num = 123;

// int SecondNumFromThree(int n)
// {
//     return (n/=10)%10;
// }
// Console.WriteLine($"Вторая цифра числа {Num} - {SecondNumFromThree(Num)}");







// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

// int Num = new Random().Next(10, 99);

// int result11(int n)
// {
//     int maxNum1 = n % 10, maxNum2 = n / 10;
//     Console.WriteLine($"{maxNum1}, {maxNum2}");
//     if (maxNum1 > maxNum2)  return maxNum1;
//     else return maxNum2;
// }
// Console.WriteLine($"Наибольшее цифра в числе {Num} - {result11(Num)}");







// 12. Удалить вторую цифру трёхзначного числа


// int Num = 723;

// int CutSecond(int n)
// {
//     return (n % 10) + ((n / 100) * 10);
// }
// Console.WriteLine(CutSecond(Num));



// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// Console.WriteLine("Введите 1 число");
// int num1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите 2 число");
// int num2 = int.Parse(Console.ReadLine());

// int result13(int n1, int n2)
// {
//     return n1%n2;
// }
// int res13 = result13(num1, num2);
// if(res13 == 0) Console.WriteLine($"Число {num1} кратно {num2}");
// else
// Console.WriteLine($"Число {num1} некратно {num2}. Остаток {res13}");


// 14. Найти третью цифру числа или сообщить, что её нет

// int Num = 12;

// int LustNumFromThree(int n)
// {
//     return n%10;
// }


// bool MoreThenThreeNum(int n)
// {
//      return (n/100) != 0;  

// }

// if(MoreThenThreeNum(Num)) Console.WriteLine($"Последняя цифра числа {Num} - {LustNumFromThree(Num)}");
// else Console.WriteLine($"третьей цифры в числе {Num} нет");