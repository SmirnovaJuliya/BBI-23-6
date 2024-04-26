using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;



abstract class Task 
{ protected string text = ""; 
    public string Text 
    { 
        get => text; 
        protected set => text = value; 
    } 
    public virtual void reshenie() { }
    public virtual void ToString() { }
    public Task(string text) { this.text = text; } 
}
class Task1 : Task
{
    private string answer;
    private string Answer { get => answer; }
    [JsonConstructor]
    public Task1(string text) : base(text) { answer = ""; }

    public override void reshenie()
    {
        string[] words = text.Split(new char[] { '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries);
        if (words.Length % 2 == 1)
        {
            int center = words.Length / 2;
            answer = words[center];
            Console.WriteLine(answer);
        }
        else
        {
            Console.WriteLine("такого слова нет");
        }
    }
}
    class Task2 : Task
    {
        private string answer;
        private string Answer { get => answer; }
        [JsonConstructor]
        public Task2(string text) : base(text) { answer = ""; }

        public override void reshenie()
        {

        }
        //public override string ToString() { reshenie(); }

    }

class JsonIO
{
    public static void Write<T>(T obj, string filePath)
    { 
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate)) 
        { 
            JsonSerializer.Serialize(fs, obj); 
        } 
    }
    public static T Read<T>(string filePath)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            return JsonSerializer.Deserialize<T>(fs);
        }
        return default(T);
    }
   

class Program
    {
        static void Main()
        {
            string text = "Скоро будет лето и все будет хорошо. Наверное.";
            Task[] tasks = { new Task1(text), new Task2(text) };
            Console.WriteLine(tasks[0]);
            Console.WriteLine(tasks[1]);
            string path = @"C:\Users\m2304666\Documents";
            string folderName = "Test";
            path = Path.Combine(path, folderName);

            if (!Directory.Exists(path))
            { Directory.CreateDirectory(path); }

            string fileName1 = "cw2_1.json";
            string fileName2 = "cw2_2.json";
            fileName1 = Path.Combine(path, fileName1);
            fileName2 = Path.Combine(path, fileName2);

            if (!File.Exists(fileName1))
            {
                JsonIO.Write<Task1>(tasks[0] as Task1, fileName1);
            }
            else
            {
                var t1 = JsonIO.Read<Task2>(fileName1); 
                Console.WriteLine(t1);
            }
            if (!File.Exists(fileName2))
            {
                JsonIO.Write<Task2>(tasks[1] as Task2, fileName2);
            }
            else 
            { 
                var t2 = JsonIO.Read<Task2>(fileName2); 
                Console.WriteLine(t2); 
            }
        }
    }
}
    

