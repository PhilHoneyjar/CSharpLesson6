// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь


System.Console.Write("Input numbers through spaces: ");
int[] numbers = System.Array.ConvertAll(System.Console.ReadLine().Split(), int.Parse);


System.Console.WriteLine($"Number of array elements greater than 0 = {CountNumbersGreaterZero(numbers)}");


int CountNumbersGreaterZero(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (numbers[i] > 0)
        {
            count++;
        }
    return count;
}