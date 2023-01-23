Console.Write("Введите  число = ");
int num = Convert.ToInt32(Console.ReadLine());

if (num<=99 )
{
    Console.WriteLine("третьей цифры числа нет");
    return;
}
else 
{
    while (num>999) 
    num = num / 10;
}    
Console.WriteLine("третья цифра числа ="+ num%10);