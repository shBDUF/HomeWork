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

// int firstNum;
// firstNum = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < firstNum; i+=2)
// {
//     Console.WriteLine(i);
// }

int firstNum;
firstNum = Convert.ToInt32(Console.ReadLine());
switch (firstNum)
{
    case < 100 when firstNum>9:
        Console.WriteLine($"Вторая цифра числа - {firstNum%10}");
        break;
    case < 1000 when firstNum>99:
        Console.WriteLine($"Вторая цифра числа - {firstNum/10%10}");
        break;
    case < 10000 when firstNum>999:
        Console.WriteLine($"Вторая цифра числа - {firstNum/100%10}");
        break;
    case < 100000 when firstNum>9999:
        Console.WriteLine($"Вторая цифра числа - {firstNum/1000%10}");
        break;
    case < 1000000 when firstNum>99999:
        Console.WriteLine($"Вторая цифра числа - {firstNum/10000%10}");
        break;
    case < 10000000 when firstNum>999999:
        Console.WriteLine($"Вторая цифра числа - {firstNum/100000%10}");
        break;
    case < 100000000 when firstNum>9999999:
        Console.WriteLine($"Вторая цифра числа - {firstNum/1000000%10}");
        break;
    default:
    Console.WriteLine("Число должно быть больше 10");
    break;
}


