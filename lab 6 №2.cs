using System;

struct Sportsmen
{
    private string famile;
    private double rez11,rez12,rez21,rez22,rez31,rez32,rez41,rez42,rez51,rez52, rez;

    public Sportsmen(string f, double r11, double r12, double r21, double r22, double r31, double r32, double r41, double r42, double r51, double r52)
    {
        famile = f;
        rez11 = r11;
        rez12 = r12;
        rez21 = r21;
        rez22 = r22;
        rez31 = r31;
        rez32 = r32;
        rez41 = r41;
        rez42 = r42;
        rez51 = r51;
        rez52 = r52;

        rez = (rez11 + rez12 + rez21 + rez22 + rez31 + rez32 + rez41 + rez42 + rez51 + rez52)/10;
        
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
        sp[0] = new Sportsmen("Иванов", 5, 3, 6, 5.5, 6, 7, 6.5, 5, 6, 6);
        sp[1] = new Sportsmen("Петров", 4, 4.5, 3, 5, 6, 5.5, 4, 5, 4.5, 5);
        sp[2] = new Sportsmen("Сидоров", 7, 6.5, 5.5, 7, 7.5, 6, 8, 7, 8, 8);
        sp[3] = new Sportsmen("Смирнов", 3.5, 4.5, 6, 5, 4.5, 5.5, 6, 5, 4, 6);
        sp[4] = new Sportsmen("Макаров", 8, 8.5, 7.5, 9, 8.5, 8, 9, 8, 9, 8.5);

        for (int i = 0; i < sp.Length - 1; i++)
        {
            for (int j = 0; j < sp.Length - i - 1; j++)
            {
                if (sp[j].GetRez() < sp[j + 1].GetRez())
                {
                    Sportsmen temp = sp[j];
                    sp[j] = sp[j + 1];
                    sp[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < sp.Length; i++)
        {
            Console.WriteLine($"Фамилия {sp[i].GetFamile()}\t Результат {sp[i].GetRez():f2}");
        }
    }
}
