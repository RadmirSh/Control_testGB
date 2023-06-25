/*Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

Console.Write("Please write the array size ");
int size = Convert.ToInt32(Console.ReadLine());

string[] firstArray = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Please write {i+1} element: ");
    string count = Convert.ToString(Console.ReadLine());
    firstArray[i] = count;
}

string[] finalArray = new string[size];
int lenArray = 3;
int posArray = 0;

for (int j = 0; j < size; j++)
{
    if (firstArray[j].Length <= lenArray)
    {
        finalArray[posArray] = firstArray[j];
        posArray++;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(finalArray);
