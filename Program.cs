// int a, b;
// a = Convert.ToInt32(Console.ReadLine());
// b = Convert.ToInt32(Console.ReadLine());
// if (a>b)
// {
//     Console.WriteLine($"число {a} больше числа {b}");
// }
// else 
// {
//     Console.WriteLine($"число {b} больше числа {a}");
// }

int firstNum, secondNum, thirdNum;
firstNum = Convert.ToInt32(Console.ReadLine());
secondNum = Convert.ToInt32(Console.ReadLine());
thirdNum = Convert.ToInt32(Console.ReadLine());
int max = firstNum;
if(secondNum>max)
{
    max= secondNum;
}
if (thirdNum>max)
{
    max = thirdNum;
}
Console.WriteLine($"Максимальное число из трёх это {max}");