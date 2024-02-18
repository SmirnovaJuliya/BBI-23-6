// || - или
// && - и 

using System;
class Program
{
    private struct Team
    {
        public string team;
        public int scored;
        public int missed;
        public int points;
    }

    static void Main(string[] args)
    {
        Team[] teams = {
            new Team { team = "UOR", scored = 2, missed = 1 },
            new Team { team = "CSKA", scored = 1, missed = 1 },
            new Team { team = "Dinamo", scored = 0, missed = 3 },
            new Team { team = "Burevestnik", scored = 3, missed = 0 }
        };

        
        for (int i = 0; i < teams.Length; i++)
        {
            teams[i].points = teams[i].scored > teams[i].missed ? 3 : teams[i].scored == teams[i].missed ? 1 : 0;
        }
        for (int i = 0; i < teams.Length - 1; i++)
        {
            for (int j = 0; j < teams.Length - i - 1; j++)
            {
                if (teams[j].points < teams[j + 1].points || (teams[j].points == teams[j + 1].points && (teams[j].scored - teams[j].missed) < (teams[j + 1].scored - teams[j + 1].missed)))
                {
                    Team t = teams[j];
                    teams[j] = teams[j + 1];
                    teams[j + 1] = t;
                }
            }
        }

        Console.WriteLine("Результирующая таблица:");
        Console.WriteLine("Место\tКоманда\tОчки");
        for (int i = 0; i < teams.Length; i++)
        {
            Console.WriteLine($"{i + 1}\t{teams[i].team}\t{teams[i].points}");
        }

    }

   
        
    
}