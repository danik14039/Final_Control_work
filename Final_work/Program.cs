// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int Input(string message)
{
    string value = String.Empty;
    bool isNumber = false;
    int number = 0;
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        value = Console.ReadLine();
        isNumber = int.TryParse(value, out number);
        if (isNumber == true)
        {
            result = number;
            break;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Введите число:  ");
        }

    }
    return result;
}

int arrayLength = Input("Сколько элементов массива вы хотите ввести?");
string[] array = new string[arrayLength];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите " + (i + 1) + " элемент массива");
    array[i] = Console.ReadLine();
}
Console.WriteLine();
Console.WriteLine(String.Join(",", array));

string[] arrayThreeChar = new string[arrayLength];


for (int j = 0; j < array.Length; j++)
{
    if (array[j].Length - 1 < 3)
    {
        arrayThreeChar[j] = array[j];
    }
}

Console.WriteLine();
Console.WriteLine("Следующий массив выводит элементы введенного Вами массива с длиной строки меньше 3 символов");
Console.WriteLine(String.Join(" ", arrayThreeChar));