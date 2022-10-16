//Задача 43: Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();

WriteLine("Введите значения k1, b1, k2 и b2, через пробел: ");
string[] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] straight = GetArray(array);
double x = (straight[3] - straight[1])/(straight[0] - straight[2]);
double y = straight[0]*x + straight[1];
WriteLine($"Точка пересечения ({x}; {y})");



double [] GetArray(string[] parameters)
{
    double[] result = new double [parameters.Length];
    for (int i = 0; i < parameters.Length; i++)
    {
        result[i] = Convert.ToInt32(parameters[i]);
    }
    return result;
}