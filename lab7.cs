using System;

//lv 1
//class Sportsmen
//{
//    private string famile;
//    private double rez1, rez2, rez;
//    private bool disqualfieted;

//    public Sportsmen(string f, double r1, double r2)
//    {
//        famile = f;
//        rez1 = r1;
//        rez2 = r2;
//        if (rez1 > rez2)
//        {
//            rez = rez1;
//        }
//        else
//        {
//            rez = rez2;
//        }
//        disqualfieted = false;
//    }
//    public string GetFamile()
//    {
//        return famile;
//    }

//    public double GetRez()
//    {
//        return rez;
//    }
//    public void Disqualify()
//    {
//        disqualfieted = true;
//    }
//    public bool IsDisqualfieted()
//    {
//        return disqualfieted;
//    }
//    public void info()
//    {
//        Console.WriteLine($"Фамилия {GetFamile()}\t Результат {GetRez():f2}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Sportsmen[] sp = new Sportsmen[5];
//        sp[0] = new Sportsmen("Иванов", 1.50, 1.52);
//        sp[1] = new Sportsmen("Петров", 1.55, 1.8);
//        sp[2] = new Sportsmen("Сидоров", 1.47, 1.5);
//        sp[3] = new Sportsmen("Кузнецов", 1.46, 1.43);
//        sp[4] = new Sportsmen("Макаров", 1.54, 1.44);

//        sp[3].Disqualify();
//        sort(sp);
//        res(sp);

//    }
//    private static void sort(Sportsmen[] sp)
//    {
//        for (int i = 0; i < sp.Length - 1; i++)
//        {
//            for (int j = 0; j < sp.Length - i - 1; j++)
//            {
//                if (sp[j].GetRez() < sp[j + 1].GetRez())
//                {
//                    Sportsmen t = sp[j];
//                    sp[j] = sp[j + 1];
//                    sp[j + 1] = t;
//                }
//            }
//        }
//    }
//    private static void res(Sportsmen[] sp)
//    {
//        for (int i = 0; i < sp.Length; i++)
//        {
//            if (sp[i].IsDisqualfieted() == false)
//            {
//                sp[i].info();
//            }
//        }
//    }
//}

//lv 2
//abstract class Jump
//{
//    protected string name;
//    public abstract void setname();
//    public abstract void printname();
//}
//class Jump3m : Jump
//{
//    public Jump3m()
//    {
//        setname();
//    }
//    public override void setname()
//    {
//        name = "прыжки в воду с 3м вышки";
//    }
//    public override void printname()
//    {
//        Console.WriteLine($"Дисциплина: {name}");
//    }

//}
//class Jump5m : Jump
//{
//    public Jump5m()
//    {
//        setname();
//    }
//    public override void setname()
//    {
//        name = "прыжки в воду с 5м вышки";
//    }
//    public override void printname()
//    {
//        Console.WriteLine($"Дисциплина: {name}");
//    }

//}
//struct Sportsmen
//{
//    private string famile;
//    private double[] rez = new double[10];
//    private Jump jump;

//    public Sportsmen(string f, double r11, double r12, double r21, double r22, double r31, double r32, double r41, double r42, double r51, double r52)
//    {
//        famile = f;
//        rez[0] = r11;
//        rez[1] = r12;
//        rez[2] = r21;
//        rez[3] = r22;
//        rez[4] = r31;
//        rez[5] = r32;
//        rez[6] = r41;
//        rez[7] = r42;
//        rez[8] = r51;
//        rez[9] = r52;

//        if (f == "Иванов" || f == "Петров" || f == "Сидоров")
//        {
//            jump = new Jump3m();
//        }
//        else
//        {
//            jump = new Jump5m();
//        }

//    }
//    public string GetFamile()
//    {
//        return famile;
//    }

//    public double GetRez()
//    {
//        double sum = 0;
//        for (int i = 0; i < rez.Length; i++)
//        {
//            sum += rez[i];
//        }
//        return sum / rez.Length;
//    }
//    public void info()
//    {
//        jump.printname();
//        Console.WriteLine($"Фамилия: {GetFamile()}\t Результат: {GetRez():f2}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Sportsmen[] sp = new Sportsmen[5];
//        sp[0] = new Sportsmen("Иванов", 5, 3, 6, 5.5, 6, 7, 6.5, 5, 6, 6);
//        sp[1] = new Sportsmen("Петров", 4, 4.5, 3, 5, 6, 5.5, 4, 5, 4.5, 5);
//        sp[2] = new Sportsmen("Сидоров", 7, 6.5, 5.5, 7, 7.5, 6, 8, 7, 8, 8);
//        sp[3] = new Sportsmen("Смирнов", 3.5, 4.5, 6, 5, 4.5, 5.5, 6, 5, 4, 6);
//        sp[4] = new Sportsmen("Макаров", 8, 8.5, 7.5, 9, 8.5, 8, 9, 8, 9, 8.5);

//        sort(sp);
//        res(sp);
//    }
//    private static void sort(Sportsmen[] sp)
//    {
//        for (int i = 0; i < sp.Length - 1; i++)
//        {
//            for (int j = 0; j < sp.Length - i - 1; j++)
//            {
//                if (sp[j].GetRez() < sp[j + 1].GetRez())
//                {
//                    Sportsmen temp = sp[j];
//                    sp[j] = sp[j + 1];
//                    sp[j + 1] = temp;
//                }
//            }
//        }
//    }
//    private static void res(Sportsmen[] sp)
//    {

//        for (int i = 0; i < sp.Length; i++)
//        {
//            sp[i].info();
//        }
//    }
//}

//lv 3
class Program
{
    class Team
    {
        public string team { get; set; }
        public int scored { get; set; }
        public int missed { get; set; }
        public int points { get; set; }
        public string gender { get; set; }
        public virtual void calculatepoints()
        {
            points = scored > missed ? 3 : scored == missed ? 1 : 0;
        }
        public virtual void info(int place)
        {
            Console.WriteLine($"{place}\t{team}\t{gender}\t{points}");
        }
    }
    class WomenTeam : Team
    {
        public WomenTeam(string name, int Scored, int Missed)
        {
            team = name;
            scored = Scored;
            missed = Missed;
            gender = "Ж";
        }
        public override void calculatepoints()
        {
            base.calculatepoints();
            points += 1;
        }
    }
    class MenTeam : Team
    {
        public MenTeam(string name, int Scored, int Missed)
        {
            team = name;
            scored = Scored;
            missed = Missed;
            gender = "M";
        }
        public override void calculatepoints()
        {
            base.calculatepoints();
            points += 1;
        }
    }


    static void Main(string[] args)
    {
        Team[] teams =
        {
            new WomenTeam("UOR", 2, 1 ),
            new MenTeam("CSKA", 1, 1),
            new MenTeam ("Dinamo", 0, 3),
            new WomenTeam ("Unmos", 3, 0)
        };


        foreach (var team in teams)
        {
            team.calculatepoints();
        }
        sort(teams);
        res(teams);
    }


    private static void sort(Team[] teams)
    {
        for (int i = 0; i < 4 - 1; i++)
        {
            for (int j = 0; j < 4 - i - 1; j++)
            {
                if (teams[j].points < teams[j + 1].points || (teams[j].points == teams[j + 1].points && (teams[j].scored - teams[j].missed) < (teams[j + 1].scored - teams[j + 1].missed)))
                {
                    Team t = teams[j];
                    teams[j] = teams[j + 1];
                    teams[j + 1] = t;
                }
            }
        }
    }
    private static void res(Team[] teams)
    {

        Console.WriteLine("Результирующая таблица:");
        Console.WriteLine("Место\tКоманда\tПол\tОчки");
        for (int i = 0; i < teams.Length; i++)
        {
            teams[i].info(i + 1);
        }
    }
}
