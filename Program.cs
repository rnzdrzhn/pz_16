namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\new_file.txt";
            FileStream file = new FileStream(path, FileMode.Create);
            StreamWriter writer = new StreamWriter(file);
            writer.Write("А ну-ка, Бишка, прочти, что в книжке написано! Понюхала собачка книжку, да и прочь пошла. Не моё, - говорит, - дело книги читать; я дом стерегу, по ночам не сплю, лаю, воров да волков пугаю, на охоту хожу, зайку слежу, уточек ищу, поноску тащу - будет с меня и этого.");
            writer.Close();


            StreamReader reader = new StreamReader(path);
            string array = reader.ReadToEnd();
            if (array != "")
            {
                Console.WriteLine(array);
            }
            else
            {
                Console.WriteLine("File is empty");
            }
        }
    }
}
