Console.Clear();
// Вид 1 ничего не принимают, ничего не возвращают

void Method1()
{
    Console.WriteLine("SelmarionX");
}
// Method1(); // вызов метода

// Вид 2 чтото принимают, ничего не возвращают

void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст сообщения", 4 ); // сколько раз выводим текст
// Method21(count: 4, msg: "Новый текст"); другая возможность вывода текста


// Вид 3 ничего не принимают, чтото возвращают

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);  



//  вид 4 чтото принимают, чтото возвращают

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;

}
string res = Method4(10, " asdf ");
// Console.WriteLine(res); 



// Примеры for на 4 методе

string Method41(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res1 = Method41(10, " asd ");
// Console.WriteLine(res1);


//  Использование цикла в цикле на примере таблицы умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();

// }

// //=====Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками,
// маленькие буквы “к” заменить большими “К”,
// // а большие “С” маленькими “с”.
// // Ясна ли задача?

// string text = "- Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// // string s = “qwerty”
// //             012345
// // s[3] // r
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array) // метод сортировки
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPossition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPossition]) minPossition = j; // этот блок кода ищет максимальный элемент
        }
        int temporrary = array[i];
        array[i] = array[minPossition];     // в этом блоке происходит swap
        array[minPossition] = temporrary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);

