//41. Выяснить являются ли три числа сторонами треугольника
//42. Определить сколько чисел больше 0 введено с клавиатуры
//43. Написать программу преобразования десятичного числа в двоичное
//44. Найти точку пересечения двух прямых заданных уравнением y= k*x + b, b1 k1 и b2 и k2 заданы
//45. Показать числа Фибоначчи
//46. Написать программу масштабирования фигуры
//47. Написать программу копирования массива




//41.
// Выяснить являются ли три числа сторонами треугольника

// int AB = 5, AC = 2, BC = 3;

// bool Trungle(int a, int b, int c)
// {
//     Console.WriteLine($"Расстояния равны {a} , {b}, {c}");
//     return ((a + b)>c) && ((a+c) > b) && ((b+c) > a);
// }
// // Console.WriteLine($"Стороны треугольника равны {AB} , {AC}, {BC}");
// Console.WriteLine($"{( Trungle(5,1,2) ? "Три вершины - стороны треугольника" : "Три вершины не стороны треугольника")}");
// Console.WriteLine($"{( Trungle(1,5,2) ? "Три вершины - стороны треугольника" : "Три вершины не стороны треугольника")}");
// Console.WriteLine($"{( Trungle(1,2,5) ? "Три вершины - стороны треугольника" : "Три вершины не стороны треугольника")}");

// Console.WriteLine($"{( Trungle(1,5,5) ? "Три вершины - стороны треугольника" : "Три вершины не стороны треугольника")}");





//42. 
//Определить сколько чисел больше 0 введено с клавиатуры

// int[] CreateArray(int n)
// {
//     return new int[n];
// }

// int[] FillArrayFromConsole(int[] arr)
// {
//     for(int i = 0 ; i < arr.Length; i++ ) 
//     {
//         Console.Write($"{i+1}-е число ");
//         arr[i] = int.Parse(Console.ReadLine());
//     }
//     return arr;
// }

// string PrintArray(int[] arr)
// {
//     Console.WriteLine();
//     string sum = string.Empty;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         sum+= arr[i] + " ";    
//     }
//     return sum;
// }

// int Result42(int[] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] > 0) sum++;
//     }
//     return sum;
// }

// Console.WriteLine("Обозначьте количество чисел, которое будете вводить:");
// int N = int.Parse(Console.ReadLine());
// int[] Array = FillArrayFromConsole(CreateArray(N));
// Console.WriteLine(PrintArray(Array));
// Console.WriteLine($"Чисел больше нуля введено {Result42(Array)}");


//43. 
//Написать программу преобразования десятичного числа в двоичное

//1 вариант
// int N = 5550;
// Console.WriteLine($"{N} в двоичной системе {ConvertToBin(N)}");

// int ConvertToBin(int n)
// {
//     int num = n, result = 0;
//     int powing = 0;

//     while(num > 0)
//     {
//         result += num%2 * (int)Math.Pow(10, powing);
//         Console.Write(result + " ");
//         powing++;
//         num/=2;

//     }
//     return result;
// }

//2 Вариант
// int N = 5529920;
// Console.WriteLine($"{N} в двоичной системе {ConvertToBin(N)}");
// string Testing = Convert.ToString(N, 2);
// Console.WriteLine($"{N} Проверка работы -  {Testing}");

// string ConvertToBin(int num)
// {
//     //int num = n;
//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = result.Insert(0, Convert.ToString(num % 2));
//         num /= 2;
//     }
//     return result;
// }

//44. 
//Найти точку пересечения двух прямых заданных уравнением y= k*x + b, b1 k1 и b2 и k2 заданы

int b1 = 2, k1 = 1, b2 = 0, k2 = 2;


int[] result44(int b1, int b2, int k1, int k2)
{

    int[] result = new int[2];
    result[0] = (b1 - b2) / (k2 - k1);
    result[1] = k2 * result[0] + b2;
    return result;
}

if (k1 != k2)
{
    int[] res44 = result44(b1, b2, k1, k2);
    Console.WriteLine($"Точка пересечения прямых y = {k1}x + {b1} и y = {k2}x + {b2}: \nx =  {res44[0]} , y = {res44[1]}");
}
else
{
    Console.WriteLine("Прямые параллельны");

}