using lab_9_num_2.Serel;
using Microsoft.VisualBasic;
using ProtoBuf;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using static System.Net.WebRequestMethods;

//namespace num2
//{
//    [Serializable]
//    [ProtoContract]
//    public abstract class Sportsmen
//    {
//         string _Famile;

//        public string Famile
//        {
//            get { return _Famile; }
//            set { _Famile = value ?? string.Empty;}
//        }



//        public double[] Rez { get; set; } = new double[10];

//        public string JumpType { get; set; } // Новое поле для хранения дисциплины прыжка
//        public Sportsmen() { }
//        public Sportsmen(string f, double r11, double r12, double r21, double r22, double r31, double r32, double r41, double r42, double r51, double r52)
//        {
//            Famile = f;
//            Rez[0] = r11;
//            Rez[1] = r12;
//            Rez[2] = r21;
//            Rez[3] = r22;
//            Rez[4] = r31;
//            Rez[5] = r32;
//            Rez[6] = r41;
//            Rez[7] = r42;
//            Rez[8] = r51;
//            Rez[9] = r52;

//            JumpType = f == "Иванов" || f == "Петров" || f == "Сидоров" ? "Прыжки в воду с 3м вышки" : "Прыжки в воду с 5м вышки";
//        }



//        public double GetRez()
//        {
//            double sum = 0;
//            for (int i = 0; i < Rez.Length; i++)
//            {
//                sum += Rez[i];
//            }
//            return sum / Rez.Length;
//        }

//        public void info()
//        {
//            Console.WriteLine($"Дисциплина: {JumpType}");
//            Console.WriteLine($"Фамилия: {Famile}\tРезультат: {Rez:f2}");
//        }
//    }
//}
//namespace num2
//{
//    [ProtoContract]
//    public abstract class Jump
//    {
//        public string Name { get; set; }

//        public Jump() { }

//        public abstract void SetName();

//        public abstract void PrintName();
//    }
//    [ProtoContract]
//    public class Jump3m : Jump
//    {
//        public Jump3m() : base()
//        {
//            SetName();
//        }

//        public override void SetName()
//        {
//            Name = "Прыжки в воду с 3м вышки";
//        }

//        public override void PrintName()
//        {
//            Console.WriteLine($"Дисциплина: {Name}");
//        }
//    }
//    [ProtoContract]
//    public class Jump5m : Jump
//    {
//        public Jump5m() : base()
//        {
//            SetName();
//        }

//        public override void SetName()
//        {
//            Name = "Прыжки в воду с 5м вышки";
//        }

//        public override void PrintName()
//        {
//            Console.WriteLine($"Дисциплина: {Name}");
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Directory.CreateDirectory("serialization");

//            Sportsmen[] sp = new Sportsmen[5];
//            sp[0] = new Sportsmen("Иванов", 5, 3, 6, 5.5, 6, 7, 6.5, 5, 6, 6);
//            sp[1] = new Sportsmen("Петров", 4, 4.5, 3, 5, 6, 5.5, 4, 5, 4.5, 5);
//            sp[2] = new Sportsmen("Сидоров", 7, 6.5, 5.5, 7, 7.5, 6, 8, 7, 8, 8);
//            sp[3] = new Sportsmen("Смирнов", 3.5, 4.5, 6, 5, 4.5, 5.5, 6, 5, 4, 6);
//            sp[4] = new Sportsmen("Макаров", 8, 8.5, 7.5, 9, 8.5, 8, 9, 8, 9, 8.5);

//            sort(sp);

//            ISer[] serializers = new ISer[3]
//            {
//                new JsonSer(),
//                new XMLSer(),
//                new BinSer()
//            };

//            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            string folder = "Divers";
//            path = Path.Combine(path, folder);
//            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

//            string[] files = new string[3]
//            {
//                "sportsmen.json",
//                "sportsmen.xml",
//                "sportsmen.bin"
//            };

//            for (int i = 0; i < serializers.Length; i++)
//            {
//                serializers[i].Write(sp, Path.Combine(path, files[i]));
//            }

//            for (int i = 0; i < serializers.Length; i++)
//            {
//                sp = serializers[i].Read<Sportsmen[]>(Path.Combine(path, files[i]));
//                for (int k = 0; k < sp.Length; k++)
//                {
//                    sp[k].info();
//                }
//            }
//        }

//        private static void sort(Sportsmen[] sp)
//        {
//            for (int i = 0; i < sp.Length - 1; i++)
//            {
//                for (int j = 0; j < sp.Length - i - 1; j++)
//                {
//                    if (sp[j].GetRez() < sp[j + 1].GetRez())
//                    {
//                        Sportsmen temp = sp[j];
//                        sp[j] = sp[j + 1];
//                        sp[j + 1] = temp;
//                    }
//                }
//            }
//        }

//    }
//}

//[Serializable]
//[ProtoContract]

//[ProtoInclude(1, typeof(Jump3m))]
//[ProtoInclude(2, typeof(Jump5m))]
//public abstract class Jump
//{
//    protected string _name;
//    [ProtoMember(3)]
//    public string name
//    {
//        get { return _name; }
//        set { _name = value ?? string.Empty; }
//    }
//    public abstract void setname();
//    public abstract void printname();
//}
//[ProtoContract]
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
//[ProtoContract]
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
//[ProtoContract]
//public struct Sportsmen
//{
//    [ProtoMember(4)]
//    private string famile;
//    [ProtoMember(5)]
//    private double[] rez;
//    [ProtoMember(6)]
//    private Jump jump;

//    public Sportsmen(string f, double r11, double r12, double r21, double r22, double r31, double r32, double r41, double r42, double r51, double r52)
//    {
//        famile = f;
//        rez = new double[10] { r11, r12, r21, r22, r31, r32, r41, r42, r51, r52 };


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
//        foreach (var r in rez)
//        {
//            sum += r;
//        }
//        return sum / rez.Length;
//    }


//public void info()
//    {
//        jump.printname();
//        Console.WriteLine($"Фамилия: {GetFamile()}\t Результат: {GetRez():f2}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Directory.CreateDirectory("serialization");

//        Sportsmen[] sp = new Sportsmen[5];
//        sp[0] = new Sportsmen("Иванов", 5, 3, 6, 5.5, 6, 7, 6.5, 5, 6, 6);
//        sp[1] = new Sportsmen("Петров", 4, 4.5, 3, 5, 6, 5.5, 4, 5, 4.5, 5);
//        sp[2] = new Sportsmen("Сидоров", 7, 6.5, 5.5, 7, 7.5, 6, 8, 7, 8, 8);
//        sp[3] = new Sportsmen("Смирнов", 3.5, 4.5, 6, 5, 4.5, 5.5, 6, 5, 4, 6);
//        sp[4] = new Sportsmen("Макаров", 8, 8.5, 7.5, 9, 8.5, 8, 9, 8, 9, 8.5);

//        sort(sp);
//        res(sp);

//        ISer[] serializers = new ISer[3]
//            {
//                new JsonSer(),
//                new XMLSer(),
//                new BinSer()
//            };

//        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//        string folder = "Divers";
//        path = Path.Combine(path, folder);
//        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

//        string[] files = new string[3]
//        {
//                        "sportsmen.json",
//                        "sportsmen.xml",
//                        "sportsmen.bin"
//        };

//        for (int i = 0; i < serializers.Length; i++)
//        {
//            serializers[i].Write(sp, Path.Combine(path, files[i]));
//        }

//        for (int i = 0; i < serializers.Length; i++)
//        {
//            Sportsmen[] deserialized = serializers[i].Read<Sportsmen[]>(Path.Combine(path, files[i]));
//            foreach (var sportsman in deserialized)
//            {
//                sportsman.info();
//            }
//        }
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

namespace num2
{
    [Serializable]
    [ProtoContract]

    [ProtoInclude(1, typeof(Jump3m))]
    [ProtoInclude(2, typeof(Jump5m))]
    public abstract class Jump
    {
        protected string _name;
        [ProtoMember(3)]
        public string name
        {
            get { return _name; }
            set { _name = value ?? string.Empty; }
        }
        public abstract void setname();
        public abstract void printname();
    }
    [ProtoContract]
    class Jump3m : Jump
    {
        public Jump3m()
        {
            setname();
        }
        public override void setname()
        {
            _name = "прыжки в воду с 3м вышки";
        }
        public override void printname()
        {
            Console.WriteLine($"Дисциплина: {_name}");
        }

    }
    [ProtoContract]
    class Jump5m : Jump
    {
        public Jump5m()
        {
            setname();
        }
        public override void setname()
        {
            _name = "прыжки в воду с 5м вышки";
        }
        public override void printname()
        {
            Console.WriteLine($"Дисциплина: {_name}");
        }

    }
    [ProtoContract]
    public struct Sportsmen
    {
        private string _famile;
        [ProtoMember(4)]
        public string famile
        {
            get { return _famile; }
            set { _famile = value ?? string.Empty; }
        }
        private double[] _rez = new double[10];
        [ProtoMember(5)]
        public double[] rez 
        {
            get { return _rez; }
            set { _rez = value; }
        }

        private Jump jump;

        public Sportsmen(string f, double r11, double r12, double r21, double r22, double r31, double r32, double r41, double r42, double r51, double r52)
        {
            _famile = f;
            _rez[0] = r11;
            _rez[1] = r12;
            _rez[2] = r21;
            _rez[3] = r22;
            _rez[4] = r31;
            _rez[5] = r32;
            _rez[6] = r41;
            _rez[7] = r42;
            _rez[8] = r51;
            _rez[9] = r52;

            if (f == "Иванов" || f == "Петров" || f == "Сидоров")
            {
                jump = new Jump3m();
            }
            else
            {
                jump = new Jump5m();
            }

        }
        public string GetFamile()
        {
            return famile;
        }

        public double GetRez()
        {
            double sum = 0;
            for (int i = 0; i < rez.Length; i++)
            {
                sum += rez[i];
            }
            return sum / rez.Length;
        }
        public void info()
        {
            Console.WriteLine($"Фамилия: {GetFamile()}\t Результат: {GetRez():f2}");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Sportsmen[] sp = new Sportsmen[5];
            sp[0] = new Sportsmen("Иванов", 5, 3, 6, 5.5, 6, 7, 6.5, 5, 6, 6);
            sp[1] = new Sportsmen("Петров", 4, 4.5, 3, 5, 6, 5.5, 4, 5, 4.5, 5);
            sp[2] = new Sportsmen("Сидоров", 7, 6.5, 5.5, 7, 7.5, 6, 8, 7, 8, 8);
            sp[3] = new Sportsmen("Смирнов", 3.5, 4.5, 6, 5, 4.5, 5.5, 6, 5, 4, 6);
            sp[4] = new Sportsmen("Макаров", 8, 8.5, 7.5, 9, 8.5, 8, 9, 8, 9, 8.5);

            sort(sp);
            res(sp);

            ISer[] serializers = new ISer[3]
            {
                new JsonSer(),
                new XMLSer(),
                new BinSer()
            };
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = "Divers jul";
            path = Path.Combine(path, folder);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] files = new string[3]
            {
                "divers.json",
                "divers.xml",
                "divers.bin"
            };

            for (int i = 0; i < serializers.Length; i++)
            {
                serializers[i].Write(sp, Path.Combine(path, files[i]));
            }

            for (int i = 0; i < serializers.Length; i++)
            {
                sp = serializers[i].Read<Sportsmen[]>(Path.Combine(path, files[i]));
                res(sp);
            }
        }

        private static void sort(Sportsmen[] sp)
        {
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
        }
        private static void res(Sportsmen[] sp)
        {

            for (int i = 0; i < sp.Length; i++)
            {
                sp[i].info();
            }
        }
    }
}