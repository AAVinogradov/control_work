﻿// Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе Разработчик. Мы должны убедится, что базовое знакомство с IT прошло успешно.

// Задача алгоритмически не самая сложная, однако для полноценного выполнения проверочной работы необходимо:

// 1. Создать репозиторий на GitHub
// 2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// 3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// 4. Написать программу, решающую поставленную задачу
// 5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// int ManualInput()
// {
//     int value = Convert.ToInt32(Console.ReadLine());
//     return value;
// }


string[] GetMatrix()
{
    Console.Write("Введите длмнну масива: ");
    int elementsCount = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[elementsCount];
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент масива под индексом {i}: ");
        array[i] = Convert.ToString(Console.ReadLine())!;
    }
    return array; 
}

// void PrintMatrix(string[] matrix)
// {
//     for (int i = 0; i < matrix.Length; i++)
//     {
//         Console.Write($"{matrix[i]}\t");
//     }
// }
string[] ChangeData(string[] matrix1)
{
    string[] matrix2 = new string[matrix1.Length];
    for (int i = 0; i < matrix1.Length; i++)
    {
        string str = matrix1[i];
        str = str.Replace("a", "");
        str = str.Replace("A", "");
        str = str.Replace("e", "");
        str = str.Replace("E", "");
        str = str.Replace("i", "");
        str = str.Replace("I", "");
        str = str.Replace("o", "");
        str = str.Replace("O", "");
        str = str.Replace("u", "");
        str = str.Replace("U", "");
        str = str.Replace("y", "");
        str = str.Replace("Y", "");
        str = str.Replace("0", "*");
        str = str.Replace("1", "");
        str = str.Replace("2", "*");
        str = str.Replace("3", "");
        str = str.Replace("4", "*");
        str = str.Replace("5", "");
        str = str.Replace("6", "*");
        str = str.Replace("7", "");
        str = str.Replace("8", "*");
        str = str.Replace("9", "");
        matrix2[i] = str;      
    }
    return matrix2;
}

string[] myArray1 = GetMatrix();
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine($"[{string.Join(", ", myArray1)}]");
Console.WriteLine();
string[] myArray2 = ChangeData(myArray1); 
Console.WriteLine("Измененный массив:");
Console.WriteLine($"[{string.Join(", ", myArray2)}]");




// string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля."
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;
//     int lenght = text.Length;
//     for (int i = 0; i < lenght; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'k', 'K');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'В', 'в');
// Console.WriteLine(newText);
