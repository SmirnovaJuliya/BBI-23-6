using System;

struct SimpleDate
{
    public int day;
    public int month;
    public int year;

    public bool Vis()
    {
        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
        {
            return true;
        }
        return false;
    }

    public void PrintDate()
    {
        Console.WriteLine($"{day}.{month}.{year}");
    }
}

class Program
{
    static void sort(SimpleDate[] dates)
    {
        int n = dates.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (dates[j].year > dates[j + 1].year ||
                    (dates[j].year == dates[j + 1].year && dates[j].month > dates[j + 1].month) ||
                    (dates[j].year == dates[j + 1].year && dates[j].month == dates[j + 1].month && dates[j].day > dates[j + 1].day))
                {
                    SimpleDate temp = dates[j];
                    dates[j] = dates[j + 1];
                    dates[j + 1] = temp;
                }
            }
        }
    }

    static void Main()
    {
        SimpleDate[] dates = new SimpleDate[10];
        dates[0].day = 29;
        dates[1].day = 14;
        dates[2].day = 21;
        dates[3].day = 1;
        dates[4].day = 11;
        dates[5].day = 7;
        dates[6].day = 10;
        dates[7].day = 11;
        dates[8].day = 6;
        dates[9].day = 8;
        dates[0].month = 11;
        dates[1].month = 7;
        dates[2].month = 3;
        dates[3].month = 5;
        dates[4].month = 3;
        dates[5].month = 8;
        dates[6].month = 9;
        dates[7].month = 3;
        dates[8].month = 8;
        dates[9].month = 3;
        dates[0].year = 2007;
        dates[1].year = 2003;
        dates[2].year = 2016;
        dates[3].year = 2024;
        dates[4].year = 2018;
        dates[5].year = 2020;
        dates[6].year = 2007;
        dates[7].year = 2009;
        dates[8].year = 2005;
        dates[9].year = 2017;




        sort(dates);

        Console.WriteLine("Отсортированные даты:");
        Console.WriteLine("День Месяц Год");
        foreach (SimpleDate date in dates)
        {
            date.PrintDate();
        }
    }
}


