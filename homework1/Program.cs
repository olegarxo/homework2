void findTrid (string number)
{
int truNumbers = Convert.ToInt32(number);    
    if (truNumbers >= 0)
    {
        if (number.Length >= 3 )
        {
            Console.WriteLine(number[2]);
        }
        else 
        {
            Console.WriteLine("Третьего числа нет");
        }
    } 
    else 
    {
        if (number.Length >= 4 )
        {
            Console.WriteLine(number[3]);
        }
        else 
        {
            Console.WriteLine("Третьего числа нет");
        } 
    }   
}
Console.WriteLine("введите число");
string number = Console.ReadLine();
Console.WriteLine(number.Length);
findTrid(number);