// Не используя рекруссию, программа, которая выводит первые N чисел Фибоначчи.
// Первые 2 числа 0 и 1, следующее число это сумма предидущих двух.
// Если N = 5 -> 01123

Console.WriteLine("Введите целое число > единицы: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] FibonachiArray(int inputNum)
{
    int[] fibonachiArray = new int[inputNum];
    fibonachiArray[0] = 0;
    fibonachiArray[1] = 1;
    for (int i = 2; i < inputNum; i++)
    {
        fibonachiArray[i] = fibonachiArray[i-2] + fibonachiArray[i-1];
    }
    return fibonachiArray;
}

void PrintRandomArray(int[] printArray)
{
    for (int i = 0; i < printArray.Length; i ++)
    {
        Console.Write($"{printArray[i]} ");
    }
}

Console.Write($"Если N = {number} -> ");
int[] fibonachi = FibonachiArray(number);
PrintRandomArray(fibonachi);

