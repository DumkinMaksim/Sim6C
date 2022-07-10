//Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
//значения b1, k1, b2 и k2 задаются пользователем.


double FindX(double kone,double bone,double ktwo,double btwo)
{
	
	double x=(btwo-bone)/(kone-ktwo);
	return x;
}
double FindY(double kone,double bone,double ktwo,double btwo)
{
	double y=kone*(btwo-bone)/(kone-ktwo)+bone;
	return y;
}

Console.WriteLine("Enter b1 ->");
double b1=Convert.ToDouble(Console.ReadLine() );
Console.WriteLine("Enter k1 ->");
double  k1=Convert.ToDouble(Console.ReadLine() );
Console.WriteLine("Enter b2 ->");
double b2=Convert.ToDouble(Console.ReadLine() );
Console.WriteLine("Enter k2 ->");
double k2=Convert.ToDouble(Console.ReadLine() );
Console.WriteLine();
if (k1!=k2)
Console.WriteLine("the point of intersection of two straight lines Z("+FindX(k1,b1,k2,b2)+","+FindY(k1,b1,k2,b2)+")");
else
Console.WriteLine("Error,intersection point not found");