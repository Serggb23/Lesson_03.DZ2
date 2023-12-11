// // // // // Задача 2: Задайте массив на 10 целых чисел. Напишите программу, 
// // // // // которая определяет количество чётных чисел в массиве.

    int[] array = new int[10];
    int count = 0;
    Random nums = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = nums.Next(10);
        Console.Write("| " + array[i] + " ");
    }
    Console.WriteLine ("|");
    
    for (int i= 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            // count++;
        {
            Console.Write("| " + array[i] + " ");
            count++;
        }
    Console.WriteLine("|");
    Console.WriteLine(count);
    Console.ReadLine();
    
    