/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */


Console.WriteLine("введите ваше число: ");

if(int.TryParse(Console.ReadLine(), out int num))
{
    if (num>=10 && num < 10000)
    {
        int thousands = num / 1000;
        int hundreds = (num - (thousands*1000)) / 100;
        int tens = (num / 10)%10;
        int singles = num % 10;
        int resalt = thousands + hundreds + tens + singles;
        System.Console.Write($"Сумма всех чисел вашего числа: {num} = {resalt}, еденицы = {singles}, десятки = {tens}, сотни = {hundreds}, тысячи = {thousands}");
    }
    else
    {
        System.Console.WriteLine("Вы ввели слишком большое число");
    };
}
else
{
    Console.WriteLine("вы ввели не число");
}
