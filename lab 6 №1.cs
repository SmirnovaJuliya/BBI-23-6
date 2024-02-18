using System;
using System.Dynamic;

struct Sportsmen
{
    private string famile;
    private double rez1, rez2, rez;

    public Sportsmen(string f, double r1, double r2)
    {
        famile = f;
        rez1 = r1;
        rez2 = r2;
        if(rez1>rez2)
        {
            rez = rez1;
        }
        else
        {
            rez = rez2;
        }
    }
    public string GetFamile()
    {
        return famile;
    }

    public double GetRez()
    {
        return rez;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Sportsmen[] sp = new Sportsmen[5];
        sp[0] = new Sportsmen("Иванов", 1.50, 1.52);
        sp[1] = new Sportsmen("Петров", 1.55, 1.8);
        sp[2] = new Sportsmen("Сидоров", 1.47, 1.5);
        sp[3] = new Sportsmen("Кузнецов", 1.46, 1.43);
        sp[4] = new Sportsmen("Макаров", 1.54, 1.44);
        for (int i = 0; i < sp.Length - 1; i++)
        {
            for (int j = 0; j < sp.Length - i - 1; j++)
            {
                if (sp[j].GetRez() < sp[j + 1].GetRez())
                {
                    Sportsmen t = sp[j];
                    sp[j] = sp[j + 1];
                    sp[j + 1] = t;
                }
            }
        }
        for (int i = 0; i < sp.Length; i++)
        {
            Console.WriteLine($"Фамилия {sp[i].GetFamile()}\t Результат {sp[i].GetRez():f2}", sp[i].GetFamile, sp[i].GetRez);
        }
    }
}
