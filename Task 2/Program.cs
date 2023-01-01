// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
 
int m = InputNumber("Введите значение М: ");
int n = InputNumber("Введите значение N: ");
int tempSum = 0;
sumFrom_m_to_n(m, n, tempSum);


 
int InputNumber(string str)
{
    int number;
    string text;
 
    while (true)
    {
        System.Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        System.Console.WriteLine("Некорректное число");
    }
    return number;
}
 
void sumFrom_m_to_n(int number1, int number2, int sum)
{
    if (number1 > number2)
    {
        System.Console.WriteLine($"Сумма чисел от M до N: {sum} ");
        return;
    }
    sum += number1;
    number1 += 1;
    sumFrom_m_to_n(number1, number2, sum);
}