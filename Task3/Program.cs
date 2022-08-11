// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}

int value;
value = Prompt("Введите любое число : ");
if (value > 99)
{
    while (value > 999)
    {
       value = value / 10;
    }
    int result = value % 10;
    System.Console.WriteLine($"третья цифра числа равна {result}");
}
else
{
    System.Console.WriteLine($"третьей цифры нет");
}

