//Задача 4: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Write("Введите число > ");          // Вывод приглашения ввода
string inputValue = Console.ReadLine();     // Ввод строки с терминала (с консоли)
int value = Convert.ToInt32(inputValue);    // Преобразование строки в число

System.Console.WriteLine("Четные числа от 1 до " + value + ":"); 

bool Is_Chetnoe (int N)
{
    if (N%2==0) 
    {
        Console.Write(N);
        return true;        
    }
    return false;
}

int N = 1;

while (N <= value)
{
    if (Is_Chetnoe(N))
    {
        Console.WriteLine();  
    }
    
    N = N+1;
}