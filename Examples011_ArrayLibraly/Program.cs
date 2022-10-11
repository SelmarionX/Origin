
Console.Clear();
void FillArray(int[] collection)
{
    int length = collection.Length; // получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // кладём целое число из диапазона 1 - 10
        index++;
    }
}
void PrintArray(int[] col) // Void метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0; // -1 если нет элемента, чтобы отсутствующий элемент не выводился как 0. А выводился как -1
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; //new int [10] - создай новый массив в котором будет 10 элементов. По умолчанию наполняется нулями 

FillArray(array); // метод который заполняет массив
PrintArray(array); // метод выводит на экран массив (распечатал)
Console.WriteLine();
int pos = IndexOf(array, 4);
Console.WriteLine(pos);