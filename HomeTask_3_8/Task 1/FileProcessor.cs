using System;
using System.IO;
using System.Threading.Tasks;

namespace HomeTask_3_8
{
    public class FileProcessor
    {
        private const string _path = @"D:\Output\";

        public static async void Write(string input, string fileName, bool append = false)
        {
            using (var sw = new StreamWriter(_path + fileName, append))
            {
                await sw.WriteAsync(input);
            }

            Console.WriteLine("Writing completed!");
        }

        public static async ValueTask<string> Read(string fileName)
        {
            using (StreamReader sr = new StreamReader(_path + fileName))
            {
                return await sr.ReadToEndAsync();
            }
        }
    }
}
