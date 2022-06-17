/*

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12

*/

// input data
int InputNum(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// calculate summ
int CalcSum(int num){
    int summ = 0;

    if(num < 0) num = -num;

    while(num > 0){
        summ += num % 10;
        num = num / 10;
    }

    return summ;
}

// main body
int number = InputNum("Input number: ");
Console.WriteLine($"Summ: {CalcSum(number)}");
