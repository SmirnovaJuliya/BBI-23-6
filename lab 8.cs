using System;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Globalization;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

abstract class Task
{
    protected string text;
    //protected string res;
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
//            if ((currentLine + word).Length <= needlen)
//            {
//                currentLine += word + " ";
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



//class Task_9
//{
//    private Dictionary<string, char> symbs;
//    private string encodedtext;

//    public Task_9(string text)
//    {
//        ParseText(text);
//    }

//    public void ParseText(string text)
//    {
//        symbs = new Dictionary<string, char>();
//        encodedtext = EncodeText(text);
//    }

//    private string EncodeText(string inputText)
//    {
//        var popularity = new Dictionary<string, int>();
//        for (int i = 0; i < inputText.Length - 1; i++)
//        {
//            string symb = inputText.Substring(i, 2);
//            if (!char.IsLetter(symb[0]) || !char.IsLetter(symb[1])) continue;

//            if (popularity.ContainsKey(symb)) 
//                popularity[symb]++;
//            else
//                popularity[symb] = 1;
//        }

//        var sortedsymbs = popularity.OrderByDescending(b => b.Value).ToList();
//        int startCode = 0x1000; 
//        foreach (var symb in sortedsymbs)
//        {
//            if (!symbs.ContainsKey(symb.Key))
//            {
//                char code = (char)startCode++;
//                symbs.Add(symb.Key, code);
//            }
//        }

//        string encoded = inputText;
//        foreach (var code in symbs) 
//        {
//            encoded = encoded.Replace(code.Key, code.Value.ToString());
//        }
//        return encoded;
//    }

//    public string GetEncodedText()
//    {
//        return encodedtext;
//    }

//    public Dictionary<string, char> GetBigramCodes()
//    {
//        return symbs;
//    }
//}

//class Task_10
//{
//    private Dictionary<char, string> tabl;
//    private string decodedText;

//    public Task_10(string encodedText, Dictionary<char, string> codeTable)
//    {
//        this.tabl = codeTable ?? throw new ArgumentNullException(nameof(codeTable)); 
//        ParseText(encodedText);
//    }

//    public void ParseText(string encodedText)
//    {
//        decodedText = DecodeText(encodedText);
//    }

//    private string DecodeText(string encodedText)
//    {
//        string decoded = encodedText;
//        foreach (var pair in tabl) 
//        {
//            decoded = decoded.Replace(pair.Key.ToString(), pair.Value);
//        }
//        return decoded;
//    }

//    public override string ToString()
//    {
//        return $"Decoded text: {decodedText}";
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
//                result += code;
//            }
//            else
//            {
//                result += symb + " ";
//            }
//        }
//        return result;
//    }
//}


//class Task_13 : Task
//{
//    private Dictionary<char, int> LetterCounts;
//    private int TotalWords;

//    public Task_13(string text) : base(text)
//    {
//        LetterCounts = new Dictionary<char, int>();
//        TotalWords = 0;
//        ParseText();
//    }

//    public override void ParseText()
//    {
//        string[] words = text.ToLower().Split(new char[] { ' ', ',', '.', ':', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

//        foreach (string word in words)
//        {
//            if (word.Length > 0)
//            {
//                char firstLetter = word[0];
//                if (char.IsLetter(firstLetter))
//                {
//                    TotalWords++;
//                    if (LetterCounts.ContainsKey(firstLetter))
//                    {
//                        LetterCounts[firstLetter]++;
//                    }
//                    else
//                    {
//                        LetterCounts[firstLetter] = 1;
//                    }
//                }
//            }
//        }
//    }

//    public override string Print()
//    {
//        double proc = (double)LetterCounts.Count / TotalWords * 100;

//        string result = $"процент слов, начинающихся на разные буквы: {proc:F2}%\n";

//        foreach (var item in LetterCounts)
//        {
//            double percent = (double)item.Value / TotalWords * 100;
//            result += $"Letter '{item.Key}': {percent}%\n";
//        }

//        return result;
//    }

//    public override string ToString()
//    {
//        return Print();
//    }
//}


//class Task_15 : Task
//{
//    private int sum;

//public Task_15(string text) : base(text)
//    {
//    sum = 0;
//    ParseText();
//}

//public override void ParseText()
//{
//    string[] symbs = text.Split(new char[] { ' ', '.', ',', '!', '?', ':', ';', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
//    foreach (string symb in symbs)
//    {
//        if (int.TryParse(symb, out int number))
//        {
//            sum += number;
//        }
//    }
//}

//public override string Print()
//{
//    return $"сумма чисел из текста: {sum}";
//}

//public override string ToString()
//{
//    return Print();
//}
//}

class Program
{
    public static void Main()
    {
        //8
        //Task_8 task8 = new Task_8("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. За последние десятилетия рост объема вырубки достиг критических показателей. Главными факторами, способствующими этому, являются промышленные рубки, производство древесины, расширение сельскохозяйственных угодий и незаконная добыча древесины. Это приводит к серьезным экологическим последствиям, таким как потеря биоразнообразия, ухудшение климата и угроза вымирания многих видов животных и растений. Двигатель самолета – это сложная инженерная конструкция, обеспечивающая подъем, управление и движение в воздухе. Он состоит из множества компонентов, каждый из которых играет важную роль в общей работе механизма. Внутреннее устройство двигателя включает в себя компрессор, камеру сгорания, турбину и системы управления и охлаждения. Принцип работы основан на воздушно-топливной смеси, которая подвергается сжатию, воспламенению и расширению, обеспечивая движение воздушного судна.");
        //Console.WriteLine(task8);

        //9 & 10

        //Task_9 task9 = new Task_9("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии.");
        //Dictionary<string, char> bigramCodes = task9.GetBigramCodes(); //

        //Task_10 task10 = new Task_10(task9.GetEncodedText(), InvertDictionary(bigramCodes)); //кидаем закод текст и инверт словарь

        //Console.WriteLine("Task_9 output:");
        //Console.WriteLine($"Encoded Text: {task9.GetEncodedText()}");

        //Console.WriteLine("Task_10 output:");
        //Console.WriteLine(task10);

        //Console.WriteLine("Code Table:");
        //foreach (var codePair in bigramCodes)
        //{
        //    Console.WriteLine($"'{codePair.Key}': '{codePair.Value}'");
        //}

        //static Dictionary<char, string> InvertDictionary(Dictionary<string, char> dictionary)
        //{
        //    return dictionary.ToDictionary(pair => pair.Value, pair => pair.Key); //меняем местами ключ и значение
        //}


        //12

        //Task_12 task12 = new Task_12("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазони.");
        //task12.ParseText();
        //Console.WriteLine(task12.Print());

        //13

        //Task_13 task13 = new Task_13("После многолетних исследований ученые обнаружили тревожную тенденцию в вырубке лесов Амазонии. Анализ данных показал, что основной участник разрушения лесного покрова – человеческая деятельность. ");
        //Console.WriteLine(task13);

        // 15

        //Task_15 task15 = new Task_15("После многолетних исследований в 2024 году ученые обнаружили тревожную тенденцию в вырубке 13 лесов Амазонии.");
        //Console.WriteLine(task15);

    }
}
