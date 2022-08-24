// 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int randomNumber = new Random().Next(10, 100);// [10, 99] Например: 78

int firstDigit = randomNumber / 10;//Находим первое число из "randomNumber"(из примера - 7)(78 / 10 = 7)
int secondDigit = randomNumber % 10;//Находим второе число из "randomNumber"(из примера - 8)(78 % 10 = 8)
int maximum = firstDigit;
if (secondDigit > maximum) maximum = secondDigit;
Console.WriteLine($"Максимальная цифра в числе {randomNumber} - это {maximum}");//Интерполяция($ - обязательный знак)
//Console.WriteLine($"Текст: {переменная} текст");
//Console.WriteLine("Максимальная цифра в числе" + randomNumber + "это" + maximum); Конкатенация

