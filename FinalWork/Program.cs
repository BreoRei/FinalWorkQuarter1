void PrintText(String text)
/*печать текста*/
{
    Console.Write(text);
}

int UserInput()
/*ввод значения переменной*/
{
    int a = Convert.ToInt32(Console.ReadLine());
    return a;
}

string[] FillArray(string[] arg, string t)
/*метод заполнения массива строками*/
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        PrintText($"{t} {i + 1}: ");
        arg[i] = Convert.ToString(Console.ReadLine());
    }
    return arg;
}

string[] SortedArray(string[] arg)
/*метод создания нового массива и 
копирования строк в новый массив длинной меньше 4*/
{
    int count = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        if (arg[i].Length < 4)
        {
            count += 1;
        }
    }
    string[] arr = new string[count];
    int j = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        if (arg[i].Length < 4)
        {
            arr[j] = arg[i];
            j += 1;
        }
    }
    return arr;
}

void PrintArray(string[] arg)
/*печать массва*/
{
    PrintText("[");
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        if (i < arg.GetLength(0) - 1)
        {
            Console.Write($"\"{arg[i]}\", ");
        }
        else
            Console.Write($"\"{arg[i]}\"");
    }
    PrintText("]");
}
Console.Clear();
PrintText("Введите размер массива: ");
string[] array = new string[UserInput()];
string text = "Введите строку";
FillArray(array, text);
Console.Clear();
PrintArray(array);
PrintText(" -> ");
string[] sortArr = SortedArray(array);
PrintArray(sortArr);
