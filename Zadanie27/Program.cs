//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


/*Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {num} = {SumCifr(num)} ");


int SumCifr(int resalt) 
{
    int sum = 0; 

   do
   {
    sum = sum + num % 10;
    num = num / 10;
   }
   while(num > 0);
   
    return sum;
}*/

Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр числа {num} = {SumCifr(num)} ");

int SumCifr(int resalt) 
{
    int sum = 0; 
    string Num = num.ToString();
    for(int i = 0; i< Num.Length; i++)
    {
        sum = sum + (Num[i] - '0');
    }
         return sum;
}