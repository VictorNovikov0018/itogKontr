// Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

// Делаем 2 массива
string[] array1 = new string[] {"1234", "156", "-2", "computer", "science","hello", "wo"};
string[] array2 = new string[array1.Length];


// Задаем метод с проверкой (если < или = 3, то элемент попадает во второй массив)
void SecondArray(string[] array1, string[] array2)
{
     int arr = 0;
    for(int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[arr] = array1[i];
        arr++;
        }
    }
}

// Печатаем второй, заново созданный массив
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}