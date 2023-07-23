// Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
//0, 7, 7, -2, -2 → 2

void GetNumbersGreaterZero(int [] array)
{
    int count = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(array[i] > 0)
        count++;
    }
   Console.Write($"[{String.Join(",", array)}]  ->"); 
   Console.Write("Положительных чисел -> " + count);
} 


int [] GetArray()
{
    int [] array = new int[6];
    Console.Write("Введите 6 чисел: ");
    for(int i =0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
} 

int [] array = GetArray();
GetNumbersGreaterZero(array);
