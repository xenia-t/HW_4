// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

int N = Prompt("Введите натуральное число: ");

if (N > 0)
{
    Console.WriteLine($"{Sum()}");
}

else Console.WriteLine("Число не является натуральным");


int Prompt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int Sum()
{
    int sum = 0;
    string strArray = N.ToString();
    char[] arr = strArray.ToCharArray();
    for(int i = 0; i < strArray.Length; i++)
    {
        sum += Convert.ToInt32(strArray.Substring(i,1));
    }
    return sum;
}



