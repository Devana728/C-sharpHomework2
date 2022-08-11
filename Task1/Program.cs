// напишите программу которая на вход принимает трехзначное число, а на выходе показывает вторую цифру этого числа
int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}
int value;//обьявление переменной
value = Prompt("Введите трехзначное число : ");//вводим значение
if( value >=100 && value < 1000)
{
int result = value/10%10;// 
System.Console.WriteLine($"вторая цифра числа {value} равна {result}");//выводим результат
}
else
{
System.Console.WriteLine($"число {value} не трехзначное");    
}
