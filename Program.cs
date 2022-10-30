// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Например 5 элементов
Console.WriteLine("Введите число например 5");
int massive = Convert.ToInt32(Console.ReadLine());
int[]array = new int[massive];
for (int i = 0; i < massive; i++)
{
    array[i] = new Random().Next(massive+1);
    Console.WriteLine(array[i] + ";");
}
