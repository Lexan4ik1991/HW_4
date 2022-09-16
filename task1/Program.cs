Console.WriteLine("Введите число A");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int numberB = Convert.ToInt32(Console.ReadLine());
int num = numberA;
int i=0;
void Stepen (int num)
{
   for (i=1; i<numberB; i++)
   {
    num*=numberA;
   }
Console.WriteLine("A в степени B равно: " + num);
}
Stepen(num);
