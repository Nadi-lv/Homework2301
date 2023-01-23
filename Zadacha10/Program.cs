Console.Write("Введите трехзначное число = ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Вторая цифра числа = "+ (num/10) % 10);
