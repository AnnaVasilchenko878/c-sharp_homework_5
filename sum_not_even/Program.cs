// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях
void PushArray(int [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = new Random().Next(-50, 50);
  }
}
void PrintArray(int[] array)
{
  foreach (int i in array)
  {
    Console.WriteLine(i);
  }
}
void SumNotEven (int [] array)
{
  int result = 0;
  for (int i=0; i<array.Length; i++ )
  {
    if(i%2!=0)
    {
      result = result + array[i];
    }
  }
  Console.WriteLine($"Сумма чисел которые стоят на нечетной позици равна {result}");
} 
int [] numbers = new int[5];
PushArray(numbers);
PrintArray(numbers);
SumNotEven(numbers);

