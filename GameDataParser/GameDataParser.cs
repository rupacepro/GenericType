
using System.Text.Json;

public class GameDataParser
{
    public void Run()
    {
        string fileName = getFileName();
        var fileContents = File.ReadAllText(fileName);
        List<VideoGame> videoGames = deserializeJson(fileName, fileContents);
        printConsole(videoGames);
    }

    private static void printConsole(List<VideoGame> videoGames)
    {
        if (videoGames.Count > 0)
        {
            foreach (var videoGame in videoGames)
            {
                Console.WriteLine(videoGame.ToString());
            }
        }
    }

    private static List<VideoGame> deserializeJson(string fileName, string fileContents)
    {
        List<VideoGame> videoGames = default;
        try
        {
            videoGames = JsonSerializer.Deserialize<List<VideoGame>>(fileContents);
        }
        catch (JsonException ex)
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"JSON in the {fileName}  was not in a valid format. JSON body: ");
            Console.WriteLine(File.ReadAllText(fileName));
            Console.ForegroundColor = originalColor;
            throw new JsonException($"{ex.Message} The file is : {fileName}", ex);
        }

        return videoGames;
    }

    private static string getFileName()
    {
        Boolean isReadFile = default;
        String fileName = default;
        do
        {
            Console.WriteLine("Enter the name of the file you want to read: ");
            fileName = Console.ReadLine();
            if (fileName is null)
            {
                Console.WriteLine("File cannot be null.");
            }
            else if (fileName == string.Empty)
            {
                Console.WriteLine("File cannot be empty.");
            }
            else if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
            }
            else
            {
                isReadFile = true;
            }
        } while (!isReadFile);
        return fileName;
    }
}