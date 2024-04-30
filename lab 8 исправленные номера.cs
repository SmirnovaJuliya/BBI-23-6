
abstract class Task
{
    protected string text;
    public Task(string text)
    {
        this.text = text;
    }
    public abstract void ParseText();
    public abstract string Print();

}

//class Task_8 : Task
//{
//    public Task_8(string text) : base(text)
//    {
//        ParseText();
//    }
//    public override string Print()
//    {
//        return text;
//    }
//    public override string ToString()
//    {
//        return text;
//    }
//    protected string reshenie(string text)
//    {
//        string[] words = text.Split(' ');
//        int needlen = 50;
//        string result = "";
//        string currentLine = "";

//        foreach (string word in words)
//        {
//            if (currentLine.Length + word.Length + (currentLine.Length > 0 ? 1 : 0) <= needlen)
//            {
//                if (currentLine.Length > 0)
//                    currentLine += " "; 
//                currentLine += word;
//            }
//            else
//            {
//                int spaces = needlen - currentLine.Length;
//                string[] parts = currentLine.Trim().Split(' ');
//                int numGaps = parts.Length - 1;

//                for (int i = 0; i < spaces; i++)
//                {
//                    parts[i % numGaps] += " ";
//                }

//                result += string.Join(" ", parts) + "\n";
//                currentLine = word + " ";
//            }
//        }

//        if (!string.IsNullOrEmpty(currentLine))
//        {
//            int spacesToAdd = needlen - currentLine.Length;
//            string[] parts = currentLine.Trim().Split(' ');
//            int numGaps = parts.Length - 1;

//            for (int i = 0; i < spacesToAdd; i++)
//            {
//                parts[i % numGaps] += " ";
//            }

//            result += string.Join(" ", parts) + "\n";
//        }

//        return result;

//    }
//    public override void ParseText()
//    {
//        text = reshenie(text);
//        this.text = Print();
//    }
//}

//class Task_12 : Task
//{
//    private Dictionary<string, char> WordCodes;
//    private List<string> TextArray;

//    public Task_12(string text) : base(text) { }

//    public override void ParseText()
//    {
//        WordCodes = new Dictionary<string, char>();
//        TextArray = new List<string>();

//        string[] words = text.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        var popularWords = words.GroupBy(word => word)
//                                .Select(group => new { Word = group.Key, Count = group.Count() })
//                                .OrderByDescending(item => item.Count)
//                                .Take(10);

//        char code = 'a';

//        foreach (var item in popularWords)
//        {
//            if (!WordCodes.ContainsKey(item.Word))
//            {
//                WordCodes[item.Word] = code++;
//            }
//        }

//        foreach (string word in words)
//        {
//            if (WordCodes.ContainsKey(word))
//            {
//                TextArray.Add(WordCodes[word].ToString());
//            }
//            else
//            {
//                TextArray.Add(word);
//            }
//        }
//    }

//    public override string Print()
//    {
//        string result = "Задание 12:\n";
//        foreach (string symb in TextArray)
//        {
//            if (char.TryParse(symb, out char code))
//            {
//                if (WordCodes.ContainsValue(code))
//                {
//                    string word = WordCodes.FirstOrDefault(x => x.Value == code).Key;
//                    result += word + " ";
//                }
//            }
//            else
//            {
//                result += symb + " ";
//            }
//        }
//        return result;
//    }
//}
class Program
{
    public static void Main()
    {
        //8

        //Task_8 task8 = new Task_8("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
        //Console.WriteLine(task8);


        //12

        //Task_12 task12 = new Task_12("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазони.");
        //task12.ParseText();
        //Console.WriteLine(task12.Print());
    }
}