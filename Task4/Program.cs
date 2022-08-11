//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}
int value;//обьявление переменной
value = Prompt("Введите цифру от 1 до 7, обозначающую день недели : ");//вводим значение
if (value < 1 || value > 7)
{
   System.Console.WriteLine($"это не день недели");
   return;
}
if (value == 6 || value == 7)
{
  System.Console.WriteLine($"этот день выходной");//выводим результат
}
else
{
  System.Console.WriteLine($"этот день не является выходным");
}