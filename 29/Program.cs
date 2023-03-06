// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
int n = 8;
int[] array = GetArray(n);

for (int i = 0; i < n-1; i++){
    Console.Write($"{array[i]}, ");}
Console.Write($"{array[n-1]}");

Console.WriteLine($" -> [{String.Join(", ", array)}]");

int[] GetArray(int n){
    int[] result = new int[n];
    for (int i=0; i<n; i++){
    result[i] = new Random().Next(50);}
    return result;}