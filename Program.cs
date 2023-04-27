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

// int firstNum, secondNum, thirdNum;
// firstNum = Convert.ToInt32(Console.ReadLine());
// secondNum = Convert.ToInt32(Console.ReadLine());
// thirdNum = Convert.ToInt32(Console.ReadLine());
// int max = firstNum;
// if(secondNum>max)
// {
//     max= secondNum;
// }
// if (thirdNum>max)
// {
//     max = thirdNum;
// }
// Console.WriteLine($"Максимальное число из трёх это {max}");

// int firstNum;
// firstNum = Convert.ToInt32(Console.ReadLine());
// if(firstNum%2==0)
// {
//     Console.WriteLine($"Число {firstNum} делится на два без остатка");
// }
// else 
// {
//     Console.WriteLine($"Число {firstNum} не делится на два без остатка");
// }

int firstNum;
firstNum = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < firstNum; i+=2)
{
    Console.WriteLine(i);
}