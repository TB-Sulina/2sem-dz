 //Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//int number = 456;
//int number = 782;
//int randNUMB = 918; 


int randNUMB = new Random().Next(100, 1000);

Console.WriteLine(randNUMB);

int digit1 = randNUMB/100;
int digit2 = randNUMB/10;
int res = digit2-digit1*10;

{
   Console.WriteLine (res); 
}