// Итоговая задача. Из имеющегося массива строк формирует новый массив строк
// длина которых меньше или равна 3 символам

//Начало работы - задание размера массива
Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());

// Метод задать массив строк,  ручное заполнение значений
string[] FillingArray() 
{
    string[] outArray = new string [len];// длина массива
    int i = 0;
    Console.WriteLine("Введите данные :");//Пояснение для пользователя
    while (i < len)
    {
        outArray[i] = Console.ReadLine();
        i++;
    }
    return outArray;
}

// Метод печать массива строк
void PrintArray(string[] array)
{
    int i = 0;
    while (i < array.Length - 1)// Пробежать по всем элементам массива
    {
        Console.Write(array[i] + ",");
        i++;
    }
    Console.WriteLine(array[i]);//Допечатать последний элемент массива
}

string[] beginArray = FillingArray();
Console.WriteLine("Исходный массив: ");
PrintArray(beginArray);