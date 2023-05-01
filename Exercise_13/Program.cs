Console.Write("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int number = userNumber;
int quantityNumber = 0;
int result = 0;


// Determine the number of digits
if (number != 0)
{
    while (number >= 1 || number <= -1)
    {
        number /= 10;
        quantityNumber++;

    } 
}
else quantityNumber = 1;


// search third digital
if (quantityNumber >= 3)
{
    while (quantityNumber >= 3)
    {
        result = userNumber % 10;
        userNumber /= 10;
        quantityNumber -= 1;
    }

    Console.Write($"{Math.Abs(result)} - третья цифра ");
}
else
{
    Console.Write("третьей цифры нет ");
}
