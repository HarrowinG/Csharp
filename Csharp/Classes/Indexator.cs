namespace Csharp.Classes
{
    public class Indexator
    {
        private string[] words = "The quick brown fox".Split();

        //indexator
        public string this[int wordNum]
        {
            get => words[wordNum];
            set => words[wordNum] = value;
        }

        public static void Run()
        {
            string str = null;
            var a = str?[0];  //null-conditional call before square brackets

            var obj = new Indexator();
            var b = obj?[2];
        }
    }
}
