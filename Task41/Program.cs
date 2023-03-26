// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
int[] ManualInput()
{ 
  int n = 10000;
  int[] array = new int[n];
  bool AnswerTrueFalse = false;
  bool AnyNormalAnswer = false;
  int i = 0;
  while (AnswerTrueFalse == false && i < n)
  {
    Console.WriteLine("Введите число");
    array[i] = int.Parse(Console.ReadLine()!);
    AnyNormalAnswer = false;
    while (AnyNormalAnswer == false)
    {
      System.Console.WriteLine("Вы хотите прекратить ввод чисел? [да/нет] ");
      string answer = (Console.ReadLine()!);
      if (answer == "да" || answer == "нет") AnyNormalAnswer = true;
      if (answer == "да") AnswerTrueFalse = true;
    }
    i++;
  }
  int[] newarray = new int[i];
  for (int j = 0; j < i; j++)
  {
    newarray[j] = array[j];
  }
  return newarray;
}

int[] array = ManualInput();
System.Console.WriteLine(string.Join($", ", array));
int count = 0;
for (int i = 0; i < array.Length; i++)
{
  if (array[i] > 0) count++;
}
System.Console.WriteLine(count);
