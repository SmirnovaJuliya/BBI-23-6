using System;

// num 1, перенос методов sort и res внутрь класса, удаление неиспользуемых полей

// class Sportsmen
// {
//     private string famile;
//     private double rez1, rez2, rez;
//     private bool disqualfieted;

//     public Sportsmen(string f, double r1, double r2)
//     {
//         famile = f;
//         rez1 = r1;
//         rez2 = r2;
//         if (rez1 > rez2)
//         {
//             rez = rez1;
//         }
//         else
//         {
//             rez = rez2;
//         }
//         disqualfieted = false;
//     }
//     public string GetFamile()
//     {
//         return famile;
//     }

//     public double GetRez()
//     {
//         return rez;
//     }
//     public void Disqualify()
//     {
//         disqualfieted = true;
//     }
//     public bool IsDisqualfieted()
//     {
//         return disqualfieted;
//     }
//     public void info()
//     {
//         Console.WriteLine($"Фамилия {GetFamile()}\t Результат {GetRez():f2}");
//     }
//     public static void sort(Sportsmen[] sp)
//     {
//         for (int i = 0; i < sp.Length - 1; i++)
//         {
//             for (int j = 0; j < sp.Length - i - 1; j++)
//             {
//                 if (sp[j].GetRez() < sp[j + 1].GetRez())
//                 {
//                     Sportsmen t = sp[j];
//                     sp[j] = sp[j + 1];
//                     sp[j + 1] = t;
//                 }
//             }
//         }
//     }
//     public static void res(Sportsmen[] sp)
//     {
//         for (int i = 0; i < sp.Length; i++)
//         {
//             if (sp[i].IsDisqualfieted() == false)
//             {
//                 sp[i].info();
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Sportsmen[] sp = new Sportsmen[5];
//         sp[0] = new Sportsmen("Иванов", 1.50, 1.52);
//         sp[1] = new Sportsmen("Петров", 1.55, 1.8);
//         sp[2] = new Sportsmen("Сидоров", 1.47, 1.5);
//         sp[3] = new Sportsmen("Кузнецов", 1.46, 1.43);
//         sp[4] = new Sportsmen("Макаров", 1.54, 1.44);

//         sp[3].Disqualify();
//         Sportsmen.sort(sp);
//         Sportsmen.res(sp);

//     }
// }



// num 2, передача имени через конструктор в конструктор базового класса и понижение уровня доступа

//abstract class Jump
//{
//    private string name;
//    public Jump(string n)
//    {
//        name = n;
//    }
//    public void printname()
//    {
//        Console.WriteLine($"Дисциплина: {name}");
//    }
//}
//class Jump3m : Jump
//{
//    public Jump3m(string n) : base(n) { }
//}
//class Jump5m : Jump
//{
//    public Jump5m(string n) : base(n) { }
//}
//struct Sportsmen
//{
//    private string famile;
//    private double[] rez = new double[10];
//    private Jump jump;

//    public Sportsmen(string f, double r11, double r12, double r21, double r22, double r31, double r32, double r41, double r42, double r51, double r52, Jump j)
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
//        jump = j;
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
//        Jump3m jump3m = new Jump3m("прыжки в воду с 3м вышки");
//        Jump5m jump5m = new Jump5m("прыжки в воду с 5м вышки");

//        Sportsmen[] sp = new Sportsmen[5];
//        sp[0] = new Sportsmen("Иванов", 5, 3, 6, 5.5, 6, 7, 6.5, 5, 6, 6, jump3m);
//        sp[1] = new Sportsmen("Петров", 4, 4.5, 3, 5, 6, 5.5, 4, 5, 4.5, 5, jump3m);
//        sp[2] = new Sportsmen("Сидоров", 7, 6.5, 5.5, 7, 7.5, 6, 8, 7, 8, 8, jump3m);
//        sp[3] = new Sportsmen("Смирнов", 3.5, 4.5, 6, 5, 4.5, 5.5, 6, 5, 4, 6, jump5m);
//        sp[4] = new Sportsmen("Макаров", 8, 8.5, 7.5, 9, 8.5, 8, 9, 8, 9, 8.5, jump5m);

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



// num 3, сортировка merge

//class Program
//{
//    class Team
//    {
//        private string team;
//        private int scored;
//        private int missed;
//        private int points;
//        private string gender;
//        public Team(string name, int Scored, int Missed, int Points, string Gender)
//        {
//            team = name;
//            scored = Scored;
//            missed = Missed;
//            points = Points;
//            gender = Gender;
//        }
//        public int Getpoints()
//        {
//            return points;
//        }
//        public int Getscored()
//        {
//            return scored;
//        }
//        public int Getmissed()
//        {
//            return missed;
//        }
//        public virtual void calculatepoints(int Scored, int Missed)
//        {
//            scored += Scored;
//            missed += Missed;
//            points = scored > missed ? 3 : scored == missed ? 1 : 0;
//        }
//        public virtual void info(int place)
//        {
//            Console.WriteLine($"{place}\t{team}\t{gender}\t{points}");
//        }
//    }
//    class WomenTeam : Team
//    {
//        public WomenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "Ж")
//        {
//        }
//    }
//    class MenTeam : Team
//    {
//        public MenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "M")
//        {
//        }
//    }


//    static void Main(string[] args)
//    {
//        Team Unmos = new WomenTeam("Unmos", 0, 0);
//        Team Uor = new WomenTeam("UOR", 0, 0);
//        Team CSKA = new MenTeam("CSKA", 0, 0);
//        Team Dinamo = new MenTeam("Dinamo", 0, 0);

//        Unmos.calculatepoints(4, 0);
//        Uor.calculatepoints(0, 4);
//        Dinamo.calculatepoints(3, 1);
//        CSKA.calculatepoints(1, 3);

//        Team[] teams =
//        {
//            Unmos, Uor, CSKA, Dinamo
//        };

//        sort(teams);
//        res(teams);
//    }


//    private static void sort(Team[] teams)
//    {
//        int length = teams.Length;
//        if (length <= 1) return;
//        int mid = length / 2;
//        Team[] left = new Team[mid];
//        Team[] right = new Team[length - mid];
//        int i = 0;
//        int j = 0;
//        for (; i < length; i++) 
//        {
//            if(i < mid)
//            {
//                left[i] = teams[i];
//            }
//            else
//            {
//                right[j] = teams[i];
//                j++;
//            }
//        }
//        sort(left);
//        sort(right);
//        merge(left, right, teams);
//    }
//    private static void merge(Team[] left, Team[] right, Team[] teams) 
//    { 
//        int i = 0, l = 0, r = 0;

//        while (l < left.Length && r < right.Length)
//        {
//            if (left[l].Getpoints() > right[r].Getpoints())
//            {
//                teams[i] = left[l];
//                l++;
//            }
//            else
//            {
//                teams[i] = right[r];
//                r++;
//            }
//            i++;
//        }
//        while(l < left.Length)
//        {
//            teams[i] = left[l];
//            i++;
//            l++;

//        }
//        while (r < right.Length)
//        {
//            teams[i] = right[r];
//            i++;
//            r++;
//        }
//    }
//    private static void res(Team[] teams)
//    {

//        Console.WriteLine("Результирующая таблица:");
//        Console.WriteLine("Место\tКоманда\tПол\tОчки");
//        for (int i = 0; i < teams.Length; i++)
//        {
//            teams[i].info(i + 1);
//        }
//    }
//}
