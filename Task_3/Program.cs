// Напишите программу, которая задает массив из 8 элементов случайными числами и выводит их на экран. Оформите заполнение массива и вывод в виде функции.

void RandomArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0,1000); // ограничение для вывода не слишком больших случайных чисел 
        Console.Write(array[i] + ", ");
    }
}

int[] arr = new int[8];
RandomArray(arr);

