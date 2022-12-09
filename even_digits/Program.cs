//Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве
void PushArray(int [] array)
{
  for(int i=0; i<array.Length; i++)
  {
    array[i] = new Random().Next(99, 1000);
  }
}
void PrintArray(int [] array)
{
  foreach (int i in array)
  {
    Console.WriteLine(i);
  }
}
void SearchEven(int [] array) 
{
  int count = 0;
  foreach (int i in array)
  {
    if(i%2==0) count ++;
  }
  Console.WriteLine($"Четных чисел в массиве {count}");
}

int [] numbers = new int[5];
PushArray(numbers);
PrintArray(numbers);
SearchEven(numbers);
