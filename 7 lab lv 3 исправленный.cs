using System;
class Program
{
    class Team
    {
        private string team;
        private int scored;
        private int missed;
        private int points;
        private string gender;
        public Team(string name, int Scored, int Missed, int Points, string Gender)
        {
            team = name;
            scored = Scored;
            missed = Missed;
            points = Points;
            gender = Gender;
        }
        public int Getpoints()
        {
            return points;
        }
        public int Getscored()
        {
            return scored;
        }
        public int Getmissed()
        {
            return missed;
        }
        public virtual void calculatepoints(int Scored, int Missed)
        {
            scored += Scored;
            missed += Missed;
            points = scored > missed ? 3 : scored == missed ? 1 : 0;
        }
        public virtual void info(int place)
        {
            Console.WriteLine($"{place}\t{team}\t{gender}\t{points}");
        }
    }
    class WomenTeam : Team
    {
        public WomenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "Ж")
        {
        }
    }
    class MenTeam : Team
    {
        public MenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "M")
        {
        }
    }


    static void Main(string[] args)
    {
        Team Unmos = new WomenTeam("Unmos", 0, 0);
        Team Uor = new WomenTeam("UOR", 0, 0);
        Team CSKA = new MenTeam("CSKA", 0, 0);
        Team Dinamo = new MenTeam("Dinamo", 0, 0);

        Unmos.calculatepoints(4, 0);
        Uor.calculatepoints(0, 4);
        Dinamo.calculatepoints(3, 1);
        CSKA.calculatepoints(1, 3);

        Team[] teams =
        {
            Unmos, Uor, CSKA, Dinamo
        };

        sort(teams);
        res(teams);
    }
    

        private static void sort(Team[] teams)
    {
        for (int i = 0; i < 4 - 1; i++)
        {
            for (int j = 0; j < 4 - i - 1; j++)
            {
                if (teams[j].Getpoints() < teams[j + 1].Getpoints() || (teams[j].Getpoints() == teams[j + 1].Getpoints() && (teams[j].Getscored() - teams[j].Getmissed()) < (teams[j + 1].Getscored() - teams[j + 1].Getmissed())))
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