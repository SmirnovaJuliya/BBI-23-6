using System.Threading.Tasks;

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
class Task_8 : Task
{

    public Task_8(string text) : base(text)
    {
        ParseText();
    }
    public override string ToString()
    {
        return text;
    }
    public override string Print()
    {
        return text;
    }
    private string reshenie(string text)
    {
        string res;
        string[] words = text.Split(' ');
        int maxLength = 50;
        List<string> currentWords = new List<string>();
        int currentLineLength = 0;
        res = "";

        foreach (string word in words)
        {
            if (currentLineLength + word.Length + currentWords.Count <= maxLength)
            {
                currentWords.Add(word);
                currentLineLength += word.Length;
            }
            else
            {
                res += prov(currentWords, currentLineLength, maxLength) + "\n";
                currentWords = new List<string> { word };
                currentLineLength = word.Length;
            }
        }

        if (currentWords.Count > 0)
        {
            res += prov(currentWords, currentLineLength, maxLength);
        }

        return res;
    }

    private string prov(List<string> words, int currentLength, int maxWidth)
    {
        if (words.Count == 1)
            return words[0].PadRight(maxWidth);

        int totalSpaces = maxWidth - currentLength;
        int evenSpaces = totalSpaces / (words.Count - 1);
        int extraSpaces = totalSpaces % (words.Count - 1);

        string res = "";
        for (int i = 0; i < words.Count; i++)
        {
            res += words[i];
            if (i < words.Count - 1)
            {
                int spacesToAdd = evenSpaces + (i < extraSpaces ? 1 : 0);
                res += new string(' ', spacesToAdd);
            }
        }
        return res;
    }

    public override void ParseText()
    {
        text = reshenie(text);
    }
}

class Task_12 : Task
{
    
    private Dictionary<string, char> WordCodes;
    private List<string> TextArray;

    public Task_12(string text) : base(text) { }
    public void PrintCodeTable()
    {
        Console.WriteLine("Таблица кодов:");
        foreach (var pair in WordCodes)
        {
            Console.WriteLine($"{pair.Key} => {pair.Value}");
        }
    }

    public void PrintDecodedTable()
    {
        Console.WriteLine("Обратная таблица кодов:");
        foreach (var pair in WordCodes)
        {
            Console.WriteLine($"{pair.Value} => {pair.Key}");
        }
    }
    public override void ParseText()
    {
        WordCodes = new Dictionary<string, char>();
        TextArray = new List<string>();

        string[] words = text.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var popularWords = words.GroupBy(word => word).Select(group => new { Word = group.Key, Count = group.Count() }).OrderByDescending(item => item.Count).Take(10);

        char code = 'a';

        foreach (var item in popularWords)
        {
            if (!WordCodes.ContainsKey(item.Word))
            {
                WordCodes[item.Word] = code++;
            }
        }

        foreach (string word in words)
        {
            if (WordCodes.ContainsKey(word))
            {
                TextArray.Add(WordCodes[word].ToString());
            }
            else
            {
                TextArray.Add(word);
            }
        }
       
    }

    public override string Print()
    {
        string result = "";
        foreach (string symb in TextArray)
        {
            if (char.TryParse(symb, out char code))
            {
                if (WordCodes.ContainsValue(code))
                {
                    string word = WordCodes.FirstOrDefault(x => x.Value == code).Key;
                    result += word + " ";
                }
            }
            else
            {
                result += symb + " ";
            }
        }
        return result;
    }
}

class Program
{
    public static void Main()
    {
        Task_8 task8 = new Task_8(
        "После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");

        Console.WriteLine(task8);

        Task_12 task12 = new Task_12("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии.");
        task12.ParseText();
        Console.WriteLine(task12.Print());
        task12.PrintCodeTable();
        task12.PrintDecodedTable();
    }
}