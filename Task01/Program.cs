using System;

int currentYear = DateTime.Now.Year;
int[] leapYears = new int[20];
int counter = 0;

while (counter < 20)
{
    if ((currentYear % 4 == 0 || currentYear % 400 == 0) && currentYear % 100 != 0)
    {
        leapYears[counter] = currentYear;
        counter++;
    }
    currentYear++;
}
foreach (var item in leapYears)
{
    Console.WriteLine(item.ToString());
}