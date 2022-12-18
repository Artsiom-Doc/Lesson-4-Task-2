/*Задача 2: Напишите программу,
 которая принимает на вход число и
  выдаёт сумму цифр в числе,
   которые являются делителями этого числа.
452 -> 6
82 -> 2
9012 -> 3*/

int GetLengthOfNumber(int val)
{
   int count = 0;
   while(val > 0)
   {
      
      val = val / 10;
      count++;
   }
   return count;
}

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int length = GetLengthOfNumber(N);
int [] digitOfNumber = new int [length];
int sum = 0;
int count = N;
for(int i = 0; i < length; i++)
{
   digitOfNumber[i] = N % 10;
   N = N / 10;
}
for(int i = 0; i < length; i++)
{
   if(digitOfNumber[i] == 0)
   {
      digitOfNumber[i] = digitOfNumber[i] + 1;
   }
   else
   {
      if(count % digitOfNumber[i] == 0)
      {
         sum += digitOfNumber[i];
      }
      else
      {
         sum += 0;
      }
   }
}  
    
Console.Write(sum);

