/*

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]

*/

// input number
int InputNum(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// print array
void PrintArr(int[] arr){
    for(int i=0; i<arr.Length; i++){
        Console.WriteLine($"a[{i}]={arr[i]}");
    }
}

// generate array
int[] GenerateArr(int sizeArr){
    int[] a = new int[sizeArr];
    Random rnd = new Random();

    for(int i=0; i<sizeArr; i++){
        a[i] = rnd.Next(1000);
    }

    return a;
}

// main body
int size = InputNum("Input size of array: ");
int[] arr = GenerateArr(size);
PrintArr(arr);



