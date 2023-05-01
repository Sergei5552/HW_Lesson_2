Console.Write("Введите число обозначающее день неде (от 1 до 7): ");
int userNumber = Convert.ToInt32(Console.ReadLine());
while (true)
    if (userNumber > 0 & userNumber < 8)
    {
        if (userNumber > 5 & userNumber < 8)
        {
            Console.Write("Это выходной день");
        }
        else
        {
            Console.Write("Это рабочий день");
        }
    break;
    }
    else
    {
        Console.Write("Вы ввели неверное число. Введите число обозначающее день неде (от 1 до 7)");
        userNumber = Convert.ToInt32(Console.ReadLine());
    }