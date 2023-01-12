// На вход принимает число ТЮ а на выходе показывает все четные числа
//5 ->2
//8->2.4.6.8


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
    
for (int i = 2; i <= n; i += 2)
    Console.WriteLine(i);