// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11		82 -> 10		9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"{n} -> {GetSum(n)}");

int GetSum(int n){
    if(n<0){
        n *= (-1);}
    
    int count = 0;
    int m = n;
    while(m>0){
        m /=10;
        count++;}
    
    int sum = 0;
    for(int j=1; j<=count; j++){
        sum += n%10;
        n = (n - n%10)/10;}
    
    return sum;}