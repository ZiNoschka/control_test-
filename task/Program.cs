using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("Введите элементы массива через запятую:");
        string input = Console.ReadLine();

        // Разделение введенной строки на элементы массива по запятой
        string[] strings = input.Split(',');

        Console.WriteLine("Введите максимальную длинну строки для поиска:");
        int max_string_size = Convert.ToInt32(Console.ReadLine());
        string[] rez = new string[0]; // Создание массива для хранения результата

        // Перебор строк в исходном массиве и проверка их длины
        for (int index = 0; index < strings.Length; index++)
        {
            if (strings[index].Length <= max_string_size)
            {
               rez = getNewRezArray(rez, strings[index]); 
            }
        }        
     print(rez);
    }

    static string[] getNewRezArray(string[] oldArray, string value){
        int size = oldArray.Length;
        string [] newArray = new string[size + 1]; 
        Array.Copy(oldArray, newArray, size);
        newArray[size] = value;
        return newArray; 
    }

  // Вывод результата
    static void print(string[] arr){
             
        Console.WriteLine("Результат: " + arr.Length + " элемент(а)(ов)");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        } 
    }
}