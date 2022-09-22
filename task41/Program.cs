//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через запятую: ");
int[] number = StringToNum(Console.ReadLine());
PrintArray(number);
int sum = 0;
for (int i = 0; i < number.Length; i++)
{
    if (number[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine();
Console.WriteLine($"больше 0 = {sum}");


int[] StringToNum(string input)
{
    int count = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',')
        {
            count++;
        }
    }

    int[] number = new int [count];
    int index = 0;

    for (int i = 0; i < input.Length; i++)
    {
        string temp = "";

        while (input [i] != ',')
        {
        if(i != input.Length - 1)
        {
            temp += input [i].ToString();
            i++;
        }
        else
        {
            temp += input [i].ToString();
            break;
        }
        }
        number[index] = Convert.ToInt32(temp);
        index++;
    }
    return number;
}


void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}