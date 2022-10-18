// Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих на
// нечётных позициях

int size = new Random().Next(1, 10);
int[] array = new int[size];
int sum = 0;
for (int i = 0; i < size; i = i + 2)
{
    array[i] = new Random().Next(10);
    sum += array[i];
}
Console.Clear();
Console.WriteLine($"Случайный массив: [{String.Join(", ", array)}]\n"
+ $"Сумма элементов на нечётных позициях = {sum}");