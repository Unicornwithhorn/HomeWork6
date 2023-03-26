// Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.
string input()
{
  string String = "";
  while (String.Length <1 || String.Length > 8)
  {
    Console.WriteLine("Введите строку, состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры");
    String = Console.ReadLine()!;
  }
  return String;
}

string Strochka = input();
System.Console.WriteLine();
string NewStrochka = "";

for (int i = 0; i < Strochka.Length; i++)
{
  if (i == 0) 
  System.Console.Write(Strochka[i]);
  System.Console.WriteLine();

}
