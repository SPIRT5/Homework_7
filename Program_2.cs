Console.Clear();

int GetNumber (string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не число или число меньше 1, введите любое положительное число: ";

    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            if(result > 0)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(errorMessage);
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

int findLine = GetNumber("Введите позицию в строке: ");
int findColumn = GetNumber("Введите позицию в столбце: ");
int lengthLine = 4;
int lengthColumn = 5;
Random rnd = new Random();
int[,] numberArray = new int[lengthLine, lengthColumn];

for (int m = 0; m < lengthLine; m++) 
{
    for (int n = 0; n < lengthColumn; n++)
    {
        numberArray[m, n] = rnd.Next(10, 100);
        Console.Write(numberArray[m, n] + ", ");
    }
    Console.WriteLine();
}

if ((findLine - 1) > lengthLine || (findColumn - 1) > lengthColumn) 
{
    Console.WriteLine("Такого элемента в массиве нет!");
}
else {
    Console.WriteLine("Элемент массива, которой вы ищите: " + numberArray[(findLine - 1), (findColumn - 1)]);
}