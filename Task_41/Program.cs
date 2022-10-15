// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();
WriteLine("Введите числа через пробел:  ");

string[] parameters = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine($"[{String.Join(",",parameters)}]");

int PositiveNumbers = GetArray(parameters);
WriteLine($"Положительных чисел: {PositiveNumbers}");




int GetArray(string[] parameters)
{
    int numbers = 0;
	int[] array = new int[parameters.Length];
	    
	    for (int i = 0; i < parameters.Length; i++)
	    {
	        array[i] = Convert.ToInt32(parameters[i]);
	    }
	    
	    for (int i = 0; i < array.Length; i++)
	    {
	        if(array[i] > 0)
            numbers++;
	    }
	return numbers;
}


