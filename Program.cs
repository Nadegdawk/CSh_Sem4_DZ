Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task25": Task25(); break;
			case "Task27": Task27(); break;
            case "Task29": Task29(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}

void Task25()
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
{
	Console.WriteLine("Output of the number A to the power of B");

	int numA = ReadInt("number A");
	int numB = ReadInt("number B");

	Console.WriteLine($"The power {numB} of number {numA} is {Pow(numA, numB)}");
}

void Task27()
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
{
    Console.WriteLine("The sum of digits in a number");
    int s = SumDigitFromNumber (ReadInt("number"));
    Console.WriteLine($"The sum of digits in a number: {s}");
}

void Task29()
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
{
	Console.WriteLine("Specifying an array and outputting it");
	int[] array = GetArray(ReadInt("array length"));
	Console.WriteLine(ArrayToString(array));
}

int ReadInt(string argumentName)            //ввод данных пользователем
{
	Console.Write($"Input {argumentName}: ");
	return int.Parse(Console.ReadLine());
}

int Pow(int numA, int numB)          //возведение числа в любую степень
{
	int result = 1;

	for (int i = 0; i < numB; i++)
	{
		result *= numA;
	}

	return result;
}

int[] GetArray(int length)          //создание массива определенной длины
{
	int[] array = new int[length];

	for (int i = 0; i < array.Length; i++)
	{
		array[i] = ReadInt($"element {i}");
	}
	return array;
}

string ArrayToString(int[] array)           //преобразование массива в строку
{
	string result = string.Empty;
    result = $"[{array[0]}, ";
	for (int j = 1; j < array.Length-1; j++)
	{
		result += $"{array[j]}, ";
    }
    result += $"{array[array.Length-1]}]";
    return result;
}

int SumDigitFromNumber (int number)           //сумма цифр в числе
{
	string numString = number.ToString();
    int result = number % 10;
        for (int i = 0; i < numString.Length-1; i++)
    {   
        int t = (number / Pow(10,i+1)) % 10;
        result = result + t;
    }
    return result;
}