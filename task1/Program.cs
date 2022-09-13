//Напишите программу, которая принимает на вход пятизначное число и проверяет,
 //является ли оно палиндромом. Не использовать строки!


int Prompt(string message)
{
  Console.Write(message);
  string StringValue = Console.ReadLine() ?? "0";
  bool isNumber = int.TryParse(StringValue, out int value);
  if (isNumber)
  {
    return value;
  }
  throw new Exception("Данное значение невозможно преобразовать в число");

}

int ReverseNumber(int number)
{
  int result = 0;
  while (number > 0)
  {
    result = result*10 + number % 10;
    number = number / 10;
  }
  return result;
}

bool CheckingNumber(int number)
{
int reverse = ReverseNumber(number);
return reverse ==number;

}

int numberX = Prompt("Введите пятизначное число: ");


if (( 99999 > numberX) && (numberX > 10000))
{
   if (CheckingNumber(numberX))
   {
    Console.WriteLine("Это палиндром");
   }
   else
   {
    Console.WriteLine("Это не палиндром");

   }
}
else
 {
  Console.WriteLine("Это не пятизначное число");
}
