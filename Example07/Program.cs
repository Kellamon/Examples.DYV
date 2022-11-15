// Работа с функциями
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result = arg2;
    if(arg3>result) result = arg3;
    return result; // возвращение значения result
}
// массив        0  1  2  3  4 5 6  7 8
int[] array = {15,42,33,42,51,6,71,8,9};
array[0]=12; // присвоить значение 12 для массива с индексом 0
System.Console.WriteLine(array[0]);

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
System.Console.WriteLine(max);
