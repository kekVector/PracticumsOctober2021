// Почувствуй себя мидлом
// 23. Показать таблицу квадратов чисел от 1 до N 
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возведите число А в натуральную степень B используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру

// 23.
// Показать таблицу квадратов чисел от 1 до N

// int[] PowMassiv(int N)
// {
//     int[] array = new int[N];
//     for(int i = 1; i <= N; i++)
//     {
//         array[i-1] = i*i;
//     }
//     return array;

// }

// int n = 10;
// int[] arr = PowMassiv(n);
// for ( int i = 0; i < arr.Length; i++)
// {
//     Console.WriteLine($"Квадрат {i+1} - {arr[i]}");
// }

// 24.
// Найти кубы чисел от 1 до N

// int[] PowMassiv(int N)
// {
//     int[] array = new int[N];
//     for(int i = 1; i <= N; i++)
//     {
//         array[i-1] = i*i*i;
//     }
//     return array;

// }

// int n = 10;
// int[] arr = PowMassiv(n);
// for ( int i = 0; i < arr.Length; i++)
// {
//     Console.WriteLine($"Куб числа  {i+1} - {arr[i]}");
// }


// 25. 
//Найти сумму чисел от 1 до А

// int A = 10;
// int Summa(int a)
// {
//     int sum = 0;
//     for(int i = 1; i <= A; i++)
//     {
//         sum+=i;
//     }
//     return sum;
// }
// int res = Summa(A);
// Console.WriteLine($"Сумма чисел от 1 до {A} равна {res}");


// 26. Возведите число А в натуральную степень B используя цикл

// int A = 2, B = 3;

// int Stepen(int a, int b)

// {
//     int res = a;
//     for(int i = 1; i<b; i++)
//     {
//         res*=a;
//     }
//     return res;
// }
// Console.WriteLine($"{A} ^ {B} = {Stepen(A,B)}");


// 27. 
//Определить количество цифр в числе

// int num = 1289355444;
// int NumKol(int N)
// {
//     //string kol = Convert.ToString(N);
//     //return kol.Length;
//     return Convert.ToString(N).Length;
// }
// Console.WriteLine(NumKol(num));


//28. 
// Подсчитать сумму цифр в числе

// Вариант 1.
// int Num = 12345;

// int SumNum(int N)
// {
//     string number = Convert.ToString(N);
//     Console.WriteLine(number);
//     int result = 0;

//     for (int i = 0; i < number.Length; i++)
//     {
//         // Console.WriteLine(Int32.Parse(number[i]));
//         // result +=  Int32.Parse(number[i]);

//         Console.WriteLine(Convert.ToInt32(number[i].ToString()));

//         result += Convert.ToInt32(number[i].ToString());
//     }
//     return result;
//  }
// Console.WriteLine(SumNum(Num));

//Вариант 2.
// int Num = 12345;
// int SumNum(int N)
// {
//     string number = Convert.ToString(N);
//     int result = 0;
//     int perc = N;
//     for (int i = 0; i < number.Length; i++)
//     {
//         result += perc % 10;
//         perc /= 10;
//     }
//     return result;
// }
// Console.WriteLine(SumNum(Num));


// 29. Написать программу вычисления произведения чисел от 1 до N

// int N = 4;

// int MultiToN(int n)
// {
//     int sum = 1;
//     for(int i = 2; i <= N; i++) sum*=i;
//     return sum;
// }
// Console.WriteLine($"Произведение чисел от 1 до {N} = {MultiToN(N)}");


// 30. Показать кубы чисел, заканчивающихся на четную цифру
// int N = 50;
// for(int i = 1; i <= 50; i++)
// {
//     if((i*i*i)%2 == 0) Console.WriteLine($"{i*i*i}");
// }