// Тут написали метод заполнения массива
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
// Тут написали метод принта массива
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = -1; // Тут -1 на случай несуществующего числа в find
    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}
// Тут метод по поиску индекса числа find
// в массиве collection
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index<count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

// Тут задали массив
int[] array = new int[10];
//Тут вызвали методы
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int pos = IndexOf(array, 4);
System.Console.WriteLine(pos);