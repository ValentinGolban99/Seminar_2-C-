// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

string number = Convert.ToString (new Random().Next(100, 1000));
//Convert.ToString (number) - переводит число в формат "строка"
Console.WriteLine (number);
Console.WriteLine (number[0] + "" + number[2]);



