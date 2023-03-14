// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа. Перваначальный массив можно ввести с клавиатуры
// либо задать на старте выполнения алгоритма.
// пример:["hello", "2", "world", "*)"] -> ["2", "*)"]

string[] startArray = new string[] { "Kak", "Tvoi", "dela", "drug", "?" };
string[] resultArray = new string[0];

foreach (var item in startArray)
{
    if (item.Length <= 3)
    {
    Array.Resize(ref resultArray, resultArray.Length + 1);
    resultArray [resultArray.Length-1] = item; 
    }

}

Console.WriteLine($"[{String.Join("; ", startArray)}]->[{String.Join("; ", resultArray)}]");