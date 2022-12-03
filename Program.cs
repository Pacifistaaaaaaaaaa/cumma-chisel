Console.Write("Введите число");
int chislo = Convert.ToInt32(Console.ReadLine());
int s = 0;
while (chislo > 0)
{

s = s + chislo % 10;
chislo = chislo /10 ;

}
Console.WriteLine(s);
