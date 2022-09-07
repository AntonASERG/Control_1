// Итоговая задача. Из имеющегося массива строк формирует новый массив строк
// длина которых меньше или равна 3 символам

//Начало работы - задание размера массива
Console.Write("Задайте размер массива - ");
int len = int.Parse(Console.ReadLine());

string[] beginArray = FillingArray();
Console.WriteLine("Исходный массив: ");
PrintArray(beginArray);
string[] a = getSize(beginArray);
Console.WriteLine("Итоговый массив: ");
PrintArray(a);


// Метод задать массив строк,  ручное заполнение значений
string[] FillingArray() 
{
    string[] outArray = new string [len];// длина массива
    int i = 0;
    Console.WriteLine("Введите данные :");//Пояснение для пользователя
    while (i < len)
    {
        outArray[i] = Console.ReadLine();
        if (outArray[i] != null)
        {
        i++;
        }
    }
    return outArray;
}

// Метод принимает массив строк и выводит его на экран
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

// Метод - принимает массив строк, выдает новый массив, где
// исключены элементы, длина которых ,больше 3 строк
string[] getSize (string[] inputArray)
{
    // Цикл и локальные переменные для определения длины будущего массива
    int size = 0;
    int i = 0;
    while (i<inputArray.Length)
    {
        if (inputArray[i].Length<4)
        {
            size++;
        }
        i++;
    }
    //Задаем выходной масив
    string [] outputArray = new string [size];
    // Цикл и локальные переменные для заполнения выходного массива
    int k = 0;
    int j = 0;
    while (k < inputArray.Length)
    {
        if(inputArray[k].Length < 4)
        {
            outputArray[j] = inputArray[k];
            j++;
        }
        k++;
    }
    return outputArray;
}
