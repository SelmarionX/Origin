
Console.Clear();
//              0  1   2   3   4   5   6   7    
int[] array = { 1, 12, 31, 4, 15, 16, 17, 18 };

int n = array.Length; // определяем длину массива
int find = 4; // значение которое ищем в массиве индекса

int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        // break; если в массиве два одинаковых числа, выводим первое найденное 
    }
        index++; // index + 1;


}