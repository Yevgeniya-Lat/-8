/* 
Задача *5: 
Заполните спирально массив 4 на 4 по возрастанию
*/

   int Prompt(string massage) 
{
    System.Console.WriteLine(massage);
    int Value = Convert.ToInt32(Console.ReadLine());
    return Value;
}


/*
int[,] SpiralArray (int [,] array) 
{
    int count = 1;
    //первая строка слева на право
    for (int i = 0; i <= 0; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //правый столбец сверху вниз
    for (int j = array.GetLength(1)-1; j < array.GetLength(1); j++)
    {
        for (int i = array.GetLength(0)-(array.GetLength(0)-1); i < array.GetLength(0); i++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //нижняя строка с права на лево
    for (int i = array.GetLength(0)-1; i < array.GetLength(0); i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            array[i, j] = count;
            count++;
        }
    }
    // левый столбец с низу в верх
    for (int j = 0; j >= 0; j--)
    {
        for (int i = 2; i >= 1; i--)
        {
            array[i, j] = count;
            count++;
        }
    }
    // вторая строка с лева на право
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j <= 2; j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //третья строка с права на лево
    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j >= 1; j--)
        {
            array[i, j] = count;
            count++;
        }
    }
    return array;
}*/


void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}



int m, n;
 m = Prompt("Введите количество строк в массиве: ");
 n = Prompt("Введите количество столбцов в массиве: ");

System.Console.WriteLine();
int[,] Array = new int[m, n];
SpiralArray(Array);

PrintArray (Array);


//if (array[i, j] == array.GetLength(0)*array.GetLength(1)) break;  // заполнение спирали заканчивается когда значение элемента равно произведению количества строк на количество столбцов данного массива

int[,] ArraySpiral (int [,] array)
{
    int count = 1;
    int i, j ;
    while ( i = 0)
    {
        for ( j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    while(j = array.GetLength(1) - 1)
    {
        for (int i = array.GetLength(0)-(array.GetLength(0)-1); i < array.GetLength(0); i++)
        {
            array[i, j] = count;
            count++;
        }
    }

}


int[,] SpiralArray (int [,] array) 
{
    int i, j;
    int count = 1;
    //первая строка слева на право
    while(i = 0) //for (int i = 0; i <= 0; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //правый столбец сверху вниз
    for (int j = array.GetLength(1)-1; j < array.GetLength(1); j++)
    {
        for (int i = array.GetLength(0)-(array.GetLength(0)-1); i < array.GetLength(0); i++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //нижняя строка с права на лево
    for (int i = array.GetLength(0)-1; i < array.GetLength(0); i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            array[i, j] = count;
            count++;
        }
    }
    // левый столбец с низу в верх
    for (int j = 0; j >= 0; j--)
    {
        for (int i = 2; i >= 1; i--)
        {
            array[i, j] = count;
            count++;
        }
    }
    // вторая строка с лева на право
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j <= 2; j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //третья строка с права на лево
    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j >= 1; j--)
        {
            array[i, j] = count;
            count++;
        }
    }
    return array;
}
