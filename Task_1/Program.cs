// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В

int Promt(String message)
{
	Console.Write(message);
	string strValue = Console.ReadLine();
	int Value = int.Parse(strValue);
    return Value;
}

void Power(int A, int B)
{
	int result = 1;
	for (int i = 0; i < B; i++)
	{
		result *= A;
	}
	Console.WriteLine(result);
}

int A = Promt("Введите число А: ");
int B = Promt("Введите натуральное число В: ");

if (B > 0)
{
	 Power(A,B);
}

else Console.WriteLine("Введено некорректное значение В");

