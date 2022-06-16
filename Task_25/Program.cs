/*

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

int InputNum(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

long PowN(int a, int n){
    int result = 1;
    for(int i=0; i<n; i++){
        result *= a;
    }

    return result;
}

int A = InputNum("Input A: ");
int B = InputNum("Input B: ");

if(B < 0){
    // отрицательная степень не обрабатывается 
    Console.WriteLine("Wrong power!");
}
else{
    Console.WriteLine($"{A}^{B} = {PowN(A, B)}");
}