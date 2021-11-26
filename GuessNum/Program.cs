// Комп загадал число в некотором диапазоне, например от 1 до 100. 
// Далее он предлагает игроку угадать это число. 
// Игрок вводит некоторое число и комп "отвечает":

// правильное ли это число или
// Загаданное число больше чем введенное
// загаданное число меньше чем введенное. 
// После этого игрок делает следующую догадку. 
// У Игрока есть некоторое количество попыток.
// Если игрок потратил все свои попытки, то игра заканчивается.
//  Если игрок угадал число, но попытки еще остались, игра также заканчивается.

// Определить условия. (какой диапазон для загадывания чисел - мы его задаем, формируем рандомно или запрашиваем у пользователя?; 
// определиться с количеством попыток - высчитать необходимое количество попыток, либо запросить у участника)
// Загадать число в указанном диапазоне.
// Начало игры - описываем правила.
// Запрашиваем у пользователя число. 
// Пользователь вводит некоторое число (добавить проверку нештатных ситуаций). 

// Определяем как оно соотносится с нашим загаданным и даем следующие инструкции игроку. 
// Если пользователь не угадал, то у него сгорает 1 попытка.
// Игра продолжается пока есть попытки или пока пользователь не угадал число.
// int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования и вернет нам это число. 
//int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне и вернет его нам. 
//bool MakeMove(int SecretNumber, int CountOfAttempts) - метод, в котором запрограммирован 1 игровой ход, 
//в результате метод возвращает либо true, либо false. true если пользователь угадал число и игру надо остановить, 
//false, если пользователь не угадал.


// int NumberToGuess = 0;
// int MaxValue = 100;
// int MinValue = 1;
// int attampts = 7;
// void Gameinit()//Пользователь вводит максимальное значение числа, генерируется случайное число
// {

//     MinValue = 1;
//     attampts = 7;
//     MaxValue = RequestNumber($"Добро пожаловать в игру\nЯ загадаю число, а у вас будет {attampts} попыток, чтобы его угадать.\nКакое максимальное число будем угадывать?");
//     NumberToGuess = createRandomNumber(MinValue, MaxValue);
// }

// int RequestNumber(string m) //Выводит в консоль сообщение m, возвращает число, которое введёт пользователь
// {
//     Console.WriteLine(m);
//     string? messageFromUser = Console.ReadLine();
//     int EnteredNumber = 0;
//     while (!(int.TryParse(messageFromUser, out EnteredNumber)))
//     {
//         Console.WriteLine("Ошибка!\nВведите число!");
//         messageFromUser = Console.ReadLine();
//     }
//     return EnteredNumber;
// }

// int createRandomNumber(int leftBound, int rightBound)//генерируем случайное число от и до
// {
//     return (new Random().Next(leftBound, rightBound + 1));
// }

// bool WinOrLose(int att)
// {
//     return att > 0;
// }

// bool MakeMove()//делаем ход. Если игра завершается, возвращаем True
// {
//     Console.WriteLine($"Оставшееся количество попыток {attampts}");
//     int num = RequestNumber("Ваше предположение?");
//     if (attampts > 0 && num == NumberToGuess)
//     {
//         //Console.WriteLine("CONGRATULATION YOU WON!!!");
//         return true;
//     }
//     else
//     {
//         if (num > NumberToGuess) Console.WriteLine("Введеннное число больше загаданного");
//         else Console.WriteLine("Введеннное число меньше загаданного");
//         attampts--;
//         return false;
//     }
// }

// void gameStart()
// {
//     bool gameResult = false;
//     Gameinit();
//     Console.WriteLine("Я загадал число, попробуй угадать");
//     //Console.WriteLine($"Число - {NumberToGuess}");
//     do
//     {
//         gameResult = MakeMove();
//     } while (attampts > 0 && !(gameResult));
//     Console.WriteLine($" {(WinOrLose(attampts) ? "CONGRATULATION YOU WON!!!" : "U lost.")}");
// }

// gameStart();


string[] s = new string[] {"1", "2"};
string[] d = new string[] {"3" , "4"};
string[] l = s.Concat(d).ToArray();