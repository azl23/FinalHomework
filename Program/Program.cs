// Задача: Написать программу, которая из сформированного массива строк содержащих символы и числа создать массив
// из строк, в который попадут только символы, не являющиеця цифрами.
// Входные данные можно получить путём ввода с клавиатуры, но лучше сделать автогенерацию данных. 
// При решении не использовать "читерство".

string startString = Prompt("Введите массив элементов через запятую");
string[] startArray = ArrayOfString(startString);
ArrayPrint(startArray, "Входной массив строк: ");
string[] result = StringsWithLenghtLessThanThree(startArray);
ArrayPrint(result, "Итоговый массив со строками, длина которых меньше либо равна 3");

string Prompt(string message)       
{
    System.Console.WriteLine(message);
    return Console.ReadLine();
}
string[] ArrayOfString(string str)     // Получение массива строк
{
    string[] array = str.Trim().Split(",");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i].Trim();
    }
    return array;
}
string[] StringsWithLenghtLessThanThree(string[] array)     //Получения массива с длиной строк меньше либо равно 3
{
    string[] answer = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            answer[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref answer, j);
    return answer;
}
void ArrayPrint(string[] array, string message)     //Вывод массива в консоль
{
    System.Console.WriteLine(message);
    if (array.Length == 0)
    {
        System.Console.WriteLine("Массив пустой");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.WriteLine(array[i]);
        }

    }
}
