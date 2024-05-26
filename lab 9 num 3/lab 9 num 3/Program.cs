using lab_9_num_3.Serializers;
using Microsoft.VisualBasic;
using ProtoBuf;
using System;

//public class Program
//{
//    [Serializable]
//    [ProtoContract]
//    [ProtoInclude(1, typeof(WomenTeam))]
//    [ProtoInclude(2, typeof(MenTeam))]
//    public class Team
//    {
//        private string _team;
//        [ProtoMember(3)]
//        public string team
//        {
//            get { return _team; } 
//            set { _team = value ?? string.Empty; }
//        }

//        private int _scored;
//        [ProtoMember(4)]
//        public int scored 
//        { 
//            get { return _scored; } 
//            set { _scored = value; }
//        }

//        private int _missed;
//        [ProtoMember(5)]
//        public int missed 
//        { 
//            get { return _missed; } 
//            set { _missed = value; }
//        }

//        private int _points;
//        [ProtoMember(6)]
//        public int points 
//        { 
//            get { return _points; } 
//            set { _points = value; }
//        }

//        private string _gender;
//        [ProtoMember(7)]
//        public string gender 
//        { 
//            get { return _gender; }
//            set { _gender = value ?? string.Empty; }
//        }

//        public Team() { }
//        public Team(string name, int Scored, int Missed, int Points, string Gender)
//        {
//            _team = name;
//            _scored = Scored;
//            _missed = Missed;
//            _points = Points;
//            _gender = Gender;
//        }
//        public int Getpoints()
//        {
//            return _points;
//        }
//        public int Getscored()
//        {
//            return _scored;
//        }
//        public int Getmissed()
//        {
//            return _missed;
//        }
//        public virtual void calculatepoints(int Scored, int Missed)
//        {
//            _scored += Scored;
//            _missed += Missed;
//            _points = _scored > _missed ? 3 : _scored == _missed ? 1 : 0;
//        }
//        public virtual void info(int place)
//        {
//            Console.WriteLine($"{place}\t{team}\t{gender}\t{points}");
//        }

//    }
//    [ProtoContract]
//    public class WomenTeam : Team
//    {
//        public WomenTeam() : base() { }
//        public WomenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "Ж")
//        {
//        }
//    }
//    [ProtoContract]
//    public class MenTeam : Team
//    {
//        public MenTeam() : base() { }
//        public MenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "M")
//        {
//        }
//    }


//    public static void Main(string[] args)
//    {
//        WomenTeam Unmos = new WomenTeam("Unmos", 0, 0);
//        WomenTeam Uor = new WomenTeam("UOR", 0, 0);
//        MenTeam CSKA = new MenTeam("CSKA", 0, 0);
//        MenTeam Dinamo = new MenTeam("Dinamo", 0, 0);

//        Unmos.calculatepoints(4, 0);
//        Uor.calculatepoints(0, 4);
//        Dinamo.calculatepoints(3, 1);
//        CSKA.calculatepoints(1, 3);

//        WomenTeam[] womanteams =
//        {
//            Unmos, Uor
//        };
//        MenTeam[] manteams =
//        {
//            CSKA, Dinamo
//        };


//        sort(womanteams);
//        sort(manteams);
//        res(womanteams);
//        res(manteams);


//        ISer[] serializers = new ISer[3]
//            {
//                new JsonSer(),
//                new XMLSer(),
//                new BinSer()
//            };

//        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//        string folder = "Teams";
//        path = Path.Combine(path, folder);
//        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

//        string[] files = new string[3]
//        {
//                "Team.json",
//                "Team.xml",
//                "Team.bin"
//        };
//        for (int i = 0; i < serializers.Length; i++)
//        {
//            serializers[i].Write(womanteams, Path.Combine(path, files[i]));
//        }

//        for (int i = 0; i < serializers.Length; i++)

//        {
//            Console.WriteLine($"from {files[i]}");
//            womanteams = serializers[i].Read<WomenTeam[]>(Path.Combine(path, files[i]));
//            for (int k = 0; k < womanteams.Length; k++)
//            {
//                womanteams[k].info(k + 1);
//            }
//        }
//    }


//    private static void sort(Team[] teams)
//    {
//        for (int i = 0; i < teams.Length - 1; i++)
//        {
//            for (int j = 0; j < teams.Length - i - 1; j++)
//            {
//                if (teams[j].Getpoints() < teams[j + 1].Getpoints() || (teams[j].Getpoints() == teams[j + 1].Getpoints() && (teams[j].Getscored() - teams[j].Getmissed()) < (teams[j + 1].Getscored() - teams[j + 1].Getmissed())))
//                {
//                    Team t = teams[j];
//                    teams[j] = teams[j + 1];
//                    teams[j + 1] = t;
//                }
//            }
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

namespace num3
{
    public class Program
    {
        [Serializable]
        [ProtoContract]
        [ProtoInclude(1, typeof(WomenTeam))]
        [ProtoInclude(2, typeof(MenTeam))]
        public class Team
        {
            private string _team;
            [ProtoMember(3)]
            public string team
            {
                get { return _team; }
                set { _team = value ?? string.Empty; }
            }

            private int _scored;
            [ProtoMember(4)]
            public int scored
            {
                get { return _scored; }
                set { _scored = value; }
            }

            private int _missed;
            [ProtoMember(5)]
            public int missed
            {
                get { return _missed; }
                set { _missed = value; }
            }

            private int _points;
            [ProtoMember(6)]
            public int points
            {
                get { return _points; }
                set { _points = value; }
            }

            private string _gender;
            [ProtoMember(7)]
            public string gender
            {
                get { return _gender; }
                set { _gender = value ?? string.Empty; }
            }

            public Team() { }
            public Team(string name, int Scored, int Missed, int Points, string Gender)
            {
                _team = name;
                _scored = Scored;
                _missed = Missed;
                _points = Points;
                _gender = Gender;
            }
            public int Getpoints()
            {
                return _points;
            }
            public int Getscored()
            {
                return _scored;
            }
            public int Getmissed()
            {
                return _missed;
            }
            public virtual void calculatepoints(int Scored, int Missed)
            {
                _scored += Scored;
                _missed += Missed;
                _points = _scored > _missed ? 3 : _scored == _missed ? 1 : 0;
            }
            public virtual void info(int place)
            {
                Console.WriteLine($"{place}\t{team}\t{gender}\t{points}");
            }

        }
        [ProtoContract]
        public class WomenTeam : Team
        {
            public WomenTeam() : base() { }
            public WomenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "Ж")
            {
            }
        }
        [ProtoContract]
        public class MenTeam : Team
        {
            public MenTeam() : base() { }
            public MenTeam(string name, int Scored, int Missed) : base(name, Scored, Missed, 0, "M")
            {
            }
        }


        public static void Main(string[] args)
        {
            WomenTeam Unmos = new WomenTeam("Unmos", 0, 0);
            WomenTeam Uor = new WomenTeam("UOR", 0, 0);
            MenTeam CSKA = new MenTeam("CSKA", 0, 0);
            MenTeam Dinamo = new MenTeam("Dinamo", 0, 0);

            Unmos.calculatepoints(4, 0);
            Uor.calculatepoints(0, 4);
            Dinamo.calculatepoints(3, 1);
            CSKA.calculatepoints(1, 3);

            WomenTeam[] womanteams =
            {
            Unmos, Uor
            };
            MenTeam[] manteams =
            {
            CSKA, Dinamo
            };

            sort(womanteams);
            sort(manteams);
            res(womanteams);
            res(manteams);

            ISer[] serializers = new ISer[3]
            {
                new JsonSer(),
                new XMLSer(),
                new BinSer()
            };

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = "Teams";
            path = Path.Combine(path, folder);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] fileswoman = new string[3]
            {
                "TeamW.json",
                "TeamW.xml",
                "TeamW.bin"
            };
            string[] filesman = new string[3]
           {
                "TeamM.json",
                "TeamM.xml",
                "TeamM.bin"
           };
            for (int i = 0; i < serializers.Length; i++)
            {
                serializers[i].Write(womanteams, Path.Combine(path, fileswoman[i]));
                serializers[i].Write(manteams, Path.Combine(path, filesman[i]));
            }
            for (int i = 0; i < serializers.Length; i++)

            {
                Console.WriteLine($"from {fileswoman[i]}");
                womanteams = serializers[i].Read<WomenTeam[]>(Path.Combine(path, fileswoman[i]));
                for (int k = 0; k < womanteams.Length; k++)
                {
                    womanteams[k].info(k + 1);
                }
                Console.WriteLine($"from {filesman[i]}");
                manteams = serializers[i].Read<MenTeam[]>(Path.Combine(path, filesman[i]));
                for (int k = 0; k < manteams.Length; k++)
                {
                    manteams[k].info(k + 1);
                }
            }
            Console.ReadKey();
            
        }
        private static void sort(Team[] teams)
        {
            for (int i = 0; i < teams.Length - 1; i++)
            {
                for (int j = 0; j < teams.Length - i - 1; j++)
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
}