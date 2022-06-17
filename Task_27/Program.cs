/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

int InputNum(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int num = InputNum("INput number: ");
