/* Написать программу, которая из имеющегося массива строк формирует новый массив 
из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string [] array1 = {"Hello", "2", "world", ":-)", "computer science", "w@?"};
string [] array2 =  new string[array1.Length];

FillingSecondArray(array1, array2);
PrintArray(array2);

void FillingSecondArray(string [] arr1, string [] arr2)
{
    var count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}


