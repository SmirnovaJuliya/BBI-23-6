
using lab9.Serialisers;
using Microsoft.VisualBasic;
using ProtoBuf;
using System;
using System.Xml.Linq;

//namespace num1
//{
//    [Serializable]
//    [ProtoContract]
//    public class Sportsmen
//    {
//        [ProtoMember(1)]
//        public string famile;
//        [ProtoMember(2)]
//        public double rez1;
//        [ProtoMember(3)]
//        public double rez2;
//        [ProtoMember(4)]
//        public double rez;
//        [ProtoMember(5)]
//        public bool disqualfieted;

//        public Sportsmen()
//        {
//            famile = string.Empty;
//            rez1 = 0.0;
//            rez2 = 0.0;
//            rez = 0.0;
//            disqualfieted = false;
//        }

//        public Sportsmen(string f, double r1, double r2)
//        {
//            famile = f;
//            rez1 = r1;
//            rez2 = r2;
//            if (rez1 > rez2)
//            {
//                rez = rez1;
//            }
//            else
//            {
//                rez = rez2;
//            }
//            disqualfieted = false;
//        }
//        public void Disqualify()
//        {
//            disqualfieted = true;
//        }
//        public bool IsDisqualfieted()
//        {
//            return disqualfieted;
//        }
//        public override string ToString()
//        {
//            return $"Фамилия: {famile}, Результат {rez:f2}";
//        }
//    }
//    public class Program
//    {
//        static void sort(Sportsmen[] sp)
//        {
//            for (int i = 0; i < sp.Length - 1; i++)
//            {
//                for (int j = 0; j < sp.Length - i - 1; j++)
//                {
//                    if (sp[j].rez < sp[j + 1].rez)
//                    {
//                        Sportsmen t = sp[j];
//                        sp[j] = sp[j + 1];
//                        sp[j + 1] = t;
//                    }
//                }
//            }
//        }
//        static void Main(string[] args)
//        {

//            Directory.CreateDirectory("serialization");

//            Sportsmen[] sp = new Sportsmen[5];
//            sp[0] = new Sportsmen("Иванов", 1.50, 1.52);
//            sp[1] = new Sportsmen("Петров", 1.55, 1.8);
//            sp[2] = new Sportsmen("Сидоров", 1.47, 1.5);
//            sp[3] = new Sportsmen("Кузнецов", 1.46, 1.43);
//            sp[4] = new Sportsmen("Макаров", 1.54, 1.44);

//            sp[3].Disqualify();

//            sort(sp);

//            ISer[] serializers = new ISer[3]
//            {
//                new JsonSer(),
//                new XMLSer(),
//                new BinSer()
//            };

//            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
//            string folder = "Sportsmens";
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
//                    if (!sp[k].IsDisqualfieted())
//                    {
//                        Console.WriteLine(sp[k].ToString());
//                    }
//                }
//            }

//        }
//    }
//}

namespace num1
{
    [Serializable]
    [ProtoContract]
    public class Sportsmen
    {
        private string _famile;
        [ProtoMember(1)]
        public string famile
        {
            get { return _famile; }
            set { _famile = value ?? string.Empty; }
        }
        private double rez1, rez2;
        private double _rez;
        [ProtoMember(2)]
        public double rez
        {
            get { return rez1; }
            set { _rez = value; }
        }
        private bool disqualfieted;
        public Sportsmen() { }
        public Sportsmen(string f, double r1, double r2)
        {
            famile = f;
            rez1 = r1;
            rez2 = r2;
            if (rez1 > rez2)
            {
                _rez = rez1;
            }
            else
            {
               _rez = rez2;
            }
            disqualfieted = false;
        }
        public string GetFamile()
        {
            return _famile;
        }

        public double GetRez()
        {
            return _rez;
        }
        public void Disqualify()
        {
            disqualfieted = true;
        }
        public bool IsDisqualfieted()
        {
            return disqualfieted;
        }
        public void info()
        {
            Console.WriteLine($"Фамилия {GetFamile()}\t Результат {GetRez():f2}");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Sportsmen[] sp = new Sportsmen[5];
            sp[0] = new Sportsmen("Иванов", 1.50, 1.52);
            sp[1] = new Sportsmen("Петров", 1.55, 1.8);
            sp[2] = new Sportsmen("Сидоров", 1.47, 1.5);
            sp[3] = new Sportsmen("Кузнецов", 1.46, 1.43);
            sp[4] = new Sportsmen("Макаров", 1.54, 1.44);

            sp[3].Disqualify();
            sort(sp);
            res(sp);

            ISer[] serializers = new ISer[3]
            {
                new JsonSer(),
                new XMLSer(),
                new BinSer()
            };

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folder = "Sportics";
            path = Path.Combine(path, folder);
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string[] files = new string[3]
            {
                "sportic.json",
                "sportic.xml",
                "sportic.bin"
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
                        Sportsmen t = sp[j];
                        sp[j] = sp[j + 1];
                        sp[j + 1] = t;
                    }
                }
            }
        }
        private static void res(Sportsmen[] sp)
        {
            for (int i = 0; i < sp.Length; i++)
            {
                if (sp[i].IsDisqualfieted() == false)
                {
                    sp[i].info();
                }
            }
        }
    }

}