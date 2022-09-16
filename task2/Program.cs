Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int summa = 0;
void SummNumber(int num)
{
while (num > 0)
{
int result = num % 10;
num = num / 10;
summa = summa + result;
}
Console.WriteLine("сумма всех цифр равна: " + summa);
}
SummNumber(num);