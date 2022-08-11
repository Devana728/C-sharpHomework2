// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int Prompt(string message)
 {
    System.Console.Write(message);//вывести сообщение
    string readValue = Console.ReadLine();   //считывает с консоли строку
    int result = int.Parse(readValue);// преобразует строку в целое число
    return result;//возвращает результат
}

int Number = new Random().Next(100,1000);
System.Console.WriteLine(Number);
int number1 = Number / 100;
int number2 = Number % 10;
int result = number1*10 + number2;
   
System.Console.WriteLine(result);
   
   