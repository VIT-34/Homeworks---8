// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


void FillArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }

    void PrintArray(int[,,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write($"{array[i, j, k]}\t");
                }
            }
            Console.WriteLine();
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine("");
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}\t");

            }
            Console.WriteLine("");
        }

    }


    {
        int[,,] elemet = array;
        for (int i = 0; i < elemet.GetLength(0); i++)
        {
            for (int j = 0; j < elemet.GetLength(1); j++)
            {
                Console.WriteLine("");
                for (int k = 0; k < elemet.GetLength(2); k++)

                    Console.Write(" Индекс элементов " +  i +  ": "  +  array[i, j, k]);

            }
            Console.WriteLine(" ");
        }
    }
}
int[,,] array = new int[3, 3, 3];

FillArray(array);



