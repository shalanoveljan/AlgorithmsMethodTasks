Console.WriteLine("ededi daxil edin");
int number=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("old number:"+number);
static int Counter(int number)
{
    int count = 0;
    do
    {
        count++;
        number = number / 10;

    } while (number > 0);
    return count;
}


double newNumber=number+Math.Pow(10,Counter(number))*3;
Console.WriteLine("yeni eded:"+newNumber);