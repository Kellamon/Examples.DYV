// Одномерный массив array из n элементовб требуется найти элемент массив find
int[] array = {1,23,34,46,57,68,79,81};

int n = array.Length;
int find = 68;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break; // дает разрыв в выполнении команды
    }
    // index = index + 1;
    index++;
}