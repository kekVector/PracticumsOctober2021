// 31. Задать массив из 8 элементов и вывести их на экран
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


//31
//Задать массив из 8 элементов и вывести их на экран


// int[] CreatMassivNFromAtoB(int n, int a, int b)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < n; i++) array[i] = new Random().Next(a, b + 1);
//     return array;

// }

// void PrintArray(int[] arr)
// {
//     Console.WriteLine();
//     for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
//     Console.WriteLine();
// }

// int N = 8;
// int lowest = 1, highest = 100;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);







// 32. 
//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

// int N = 8; 
// int lowest = 0, highest = 1;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);




// 33. 
//Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива


int SumArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++) sum += arr[i];
    return sum;

}


// int N = 12; 
// int lowest = 0, highest = 9;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);
// int SumFrom31 = SumArray(array);
// Console.WriteLine(SumFrom31);




// 34. 
//Написать программу замену элементов массива на противоположные

// int N = 12; 
// int lowest = -9, highest = 9;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);
// int[] result34 = ChangeSign(array);
// PrintArray(result34);

int[] ChangeSign(int[] arr)
{
    int [] a = arr;
    for(int i = 0; i < arr.Length; i++) a[i]*= -1;
    return a;
}





// 35. 
//Определить, присутствует ли в заданном массиве, некоторое число

// int N = 12; 
// int lowest = 0, highest = 100;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);
// int NumFrom35 = 2;
//Console.WriteLine($"{(FindNumArray(array, NumFrom35) ? "В массиве есть число " : "В массиве нет числа ")}{NumFrom35}");

bool FindNumArray(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++) if (array[i] == n) return true;
    return false;
}







// 36. 
//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

// int N = 8;
// int lowest = 100, highest = 999;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);
// Console.WriteLine($"В вашем массиве {PositiveOrNegativeInArray(array, "+")} положительных чисел");
// Console.WriteLine($"В вашем массиве {PositiveOrNegativeInArray(array, "-")} отрицательных чисел");
// Console.WriteLine($"В вашем массиве {PositiveOrNegativeInArray(array, "0")} нулей");

int PositiveOrNegativeInArray(int[] arr, string s)
{
    int sumPos = 0, sumNeg = 0, zero = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
        {
            sumPos++;
        }
        else if (arr[i] < 0)
        {
            sumNeg ++;
        }
        else
        {
            zero++;
        }
    if(s == "+") return sumPos;
    if(s == "-") return sumNeg;
    return zero;
}



// 37.
//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// int N = 123;
// int lowest = 10, highest = 99;
// int minNum = 10, maxNum = 99;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// int Resul37 = FindFromAtoB(array, minNum, maxNum);
// Console.WriteLine($"В массиве {Resul37} с данного отрезка");

int FindFromAtoB(int[] arr, int A, int B)
{
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= A && arr[i] <= B) result++;
    }
    return result;
}







// 38. 
//Найти сумму чисел одномерного массива стоящих на нечетной позиции

// int N = 13;
// int lowest = 0, highest = 4;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// PrintArray(array);
// int res38 = Result38(array);
// Console.WriteLine($"Сумма нечетных эдементов массива = {res38}");


int Result38(int[] arr)
{
    int sum = arr[0];
    for(int i = 2; i < (arr.Length - 1); i+=2) sum+= arr[i];
    return sum;
}







// 39. 
//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// int N = 5;
// int lowest = 1, highest = 4;
// int[] array = CreatMassivNFromAtoB(N, lowest, highest);
// //array = new int[]{1, 0 , 2, 3, 2, 0, 1};
// PrintArray(array);
// int res39 = Result39(array);
// Console.WriteLine(res39);


int Result39(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < (arr.Length/2) ; i++)
    {
        sum+= arr[i] * arr[arr.Length - 1 - i];
            }
    
    if (arr.Length%2  == 0) return sum;
    else return sum + (arr[arr.Length/2]);

}





// 40. 
//В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом


// int N = 10;

// double[] array = CreatMassivDouble(N);
// PrintArrayDouble(array);
// double result40 = DivMaxMinArray(array);

double DivMaxMinArray(double[] arr)
{
    double max = arr[0], min = arr[0];
    for (int i = 1; i<arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
        if(arr[i] < min) min = arr[i];
    }
    Console.WriteLine($"Разница между максимульным {max} и минимальным {min} = {max - min}");
    return (max - min);
}

double[] CreatMassivDouble(int n)
{
    double[] array = new double[n];
    for (int i = 0; i < n; i++) array[i] = Math.Round(((new Random().NextDouble()*200) - 100), 2);
    return array;
}

void PrintArrayDouble(double[] arr)
{
    Console.WriteLine();
    for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
    Console.WriteLine();
}



