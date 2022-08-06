// Задание 2
Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber > secondNumber)
{
    Console.WriteLine( firstNumber + " " + "большее число");
    Console.WriteLine( secondNumber + " " + "меньшее");
}
else 
{
    Console.WriteLine( secondNumber + " " + "большее число");
    Console.WriteLine( firstNumber + " " + "меньшее");
}
