//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

 
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



int number = Prompt("Введите число: ");
double cube = 0;

for(int i = 1; i < number + 1; i++)
{
    cube = Math.Pow(i, 3);
    Console.WriteLine(cube);
}
