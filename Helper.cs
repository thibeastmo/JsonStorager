using JsonStorager.Domain;
using System.IO;

namespace JsonStorager
{
    public static class Helper
    {
        public static string ReadJson(string fileName)
        {
            fileName = Constants.JSON_FOLDER + fileName;
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            return "File was empty!";
        }
        public static void WriteJson(string fileName, string content)
        {
            fileName = Constants.JSON_FOLDER + fileName;
            if (File.Exists(fileName))
            {
                File.WriteAllText(fileName, content);
            }
        }
    }
}
