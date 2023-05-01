Console.Write("Введите трёхзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = 0;

userNumber /= 10;
result = userNumber % 10;


Console.Write($"{Math.Abs(result)} - вторая цифра");
