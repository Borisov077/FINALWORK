// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении задачи не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


string[] arr1 = new string[4] { "hello", "world", "2", ":-)" };
string[] arr2 = new string[arr1.Length];

void LengthArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
LengthArray(arr1, arr2);
PrintArray(arr1);
PrintArray(arr2);