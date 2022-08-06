// Задание 8
Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());
int startNumber = 2;
while(startNumber <= Number)
{
    Console.Write ( startNumber + " ");
    startNumber = startNumber+2;
}