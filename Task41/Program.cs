//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


int FindPozitivnumbers(int mnumber)
{
	int sum=0;
	for (int i=0;i<mnumber;i++)
	{
		Console.WriteLine("Enter a number: ->");
		int inputnum=Convert.ToInt32(Console.ReadLine());
		if  (inputnum>0)
		sum++;

	}
	return sum;
}

Console.WriteLine("Enter the number of items: ->");
int mnumber=Convert.ToInt32(Console.ReadLine() );
if (mnumber>0)
Console.WriteLine("Pozitiv numbers-> "+FindPozitivnumbers(mnumber));
else
Console.WriteLine("Error,see a number greater than zero");
