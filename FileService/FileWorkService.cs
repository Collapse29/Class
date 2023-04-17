namespace FileService
{
    public class FileWorkService
    {
        public string[] ReadFile(string path)
        {
            string[] data = File.ReadAllLines(path);

            return data;
        }

        public void WriteFile(string path, string data)
        {
            File.WriteAllText(path, data);
        }
    }
}