void findDay(int number)
{
    int[] days = {1,2,3,4,5,6,7};
    if (number > 0 && number < 6)
    {
    Console.WriteLine("нет");
    }
    else if (number > 5 && number < 8)
    {
    Console.WriteLine("да");
    }
    else
    {
        Console.WriteLine("Вы ввели некоректное число");
    }
}
Console.WriteLine("Введите день недели, напишите цифру");
int number = Convert.ToInt32(Console.ReadLine());
findDay(number);