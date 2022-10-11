// //f(x) = x²+1

//  возвращаемый тип f (Тип аргумента Имя аргумента)
// double f(double x) // double это если не целое число, например 2.1 4.5 и прочее
// {
//     double result = x * x + 1; // вычесление необходимого значения
//     return result; // то что должна вернуть функция, то что в дальнейшем могли использоваться например как f от 2 и кудато сохранить значение, которое посчитает нам эта функция
// }

// int a1 = 15;
// int b1 = 21;
// int c1 = 39;
// int a2 = 12;
// int b2 = 23;
// int c2 = 33;
// int a3 = 13;
// int b3 = 23;
// int c3 = 33;

// int max = a1; // определяем максимальный элемент
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;
// Console.WriteLine(max);  



int Max(int arg1, int arg2, int arg3)
{
    int result = arg1; // внутренний result, где будет храниться значение максимального
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 15;
int b1 = 21;
int c1 = 39;

int a2 = 12;
int b2 = 23;
int c2 = 33;

int a3 = 131;
int b3 = 23;
int c3 = 33;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3)); //можно написать в одну строчку
Console.WriteLine(max);