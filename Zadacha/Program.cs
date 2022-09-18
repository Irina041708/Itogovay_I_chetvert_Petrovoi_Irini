/*
Написать программу, которая из имеющего массива строк формирует массив строк, 
длина которых меньше либо равна 3 символа. 
1. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
2. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
Примеры:
["hello","2","world",":-)"]->["2",":-)"]

["1234","1567","-2","computer science"]->["-2"]

["Russia","Denmark","Kazan"]->[]
*/

Console.Clear();

string[] array = new string[4] { "hello", "2202", "world", ":-)" };

Console.WriteLine($"Исходный массив: ");
Console.Write($" x = [");
PrintArray(array);
Console.WriteLine($"]");



void PrintArray(string[] arrayy)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" '{1}'  ", i, arrayy[i]);
    }
}

