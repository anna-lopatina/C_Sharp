// Программа, которая по заданному номеру четверти показывает диапазон 
// возможных координат точек в этой четверти

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4: ");
int num = int.Parse(Console.ReadLine()!);
switch (num)
{
    case 1:
    {
        Console.WriteLine("x > 0, y > 0 ");
        break;
    }
    case 2:
    {
        Console.WriteLine("x < 0, y > 0 ");
        break;
    }
   case 3:
    {
        Console.WriteLine("x < 0, y < 0 ");
        break;
    }
    case 4:
    {
        Console.WriteLine("x > 0, y < 0 ");
        break;
    }
    default:
    {
        Console.WriteLine("Введите заданное число от 1 до 4");
        break;
    }
}
// if(num == 1)
// {
//    Console.WriteLine("x > 0, y > 0 ");
//}
//else if(num == 2)
//{
//    Console.WriteLine("x < 0, y > 0 ");
//}
//else if(num == 3)
//
//{
//    Console.WriteLine("x < 0, y < 0 ");
//}
//else if(num == 4)
//{
//    Console.WriteLine("x > 0, y < 0 ");
//}
//else
//{
//    Console.WriteLine("Введите заданное число от 1 до 4");
//}