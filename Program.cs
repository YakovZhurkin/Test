// адача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int size = Prompt("Введите размерность массива: ");
string[] array = new string [size];
FillStringArray(array);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Vассив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(symbol_three(array));

int Prompt(string message)
{
    Console.Write(message);
    int number = int.Parse(Console.ReadLine()!);
    return number;
}

void FillStringArray(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     stringArray[i] = Console.ReadLine();
  }
}


void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i =0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length-1]}"); 
    Console.Write("]");
}


string [] symbol_three (string [] StringArray)
{
  int n = 0;
  for (int i = 0;i<StringArray.Length;i++)
  {
    if(StringArray[i].Length <=3)
    n++;
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<StringArray.Length;i++)
  {
    if(StringArray[i].Length <=3)
    {
        rez[j] = StringArray[i];
        j++;
    }
  }
  return rez;
}

