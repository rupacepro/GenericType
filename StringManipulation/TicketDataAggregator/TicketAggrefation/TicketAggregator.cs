

using UglyToad.PdfPig.Content;
using UglyToad.PdfPig;
using System.Globalization;
using System.Text;

public class TicketAggregator
{
    private readonly string _ticketFolder;
    private readonly IFileWriter _fileWriter;

    public TicketAggregator(
        string ticketFolder, 
        IFileWriter fileWriter)
    {
        _ticketFolder = ticketFolder;
        _fileWriter = fileWriter;
    }

    public void Run()
    {
        StringBuilder stringBuilder = new StringBuilder();
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        foreach (var eachpdf in Directory.GetFiles(_ticketFolder, "*.pdf"))
        {
            using PdfDocument document = PdfDocument.Open(eachpdf);
            IEnumerable<string> lines = ReadEachFile(document);
            stringBuilder.AppendLine(string.Join(Environment.NewLine, lines));
        }
        _fileWriter.WriteTo(stringBuilder.ToString(), _ticketFolder, "aggregatedTicket.txt");
    }

    private IEnumerable<string> ReadEachFile(PdfDocument document)
    {
        List<string> result = new List<string>();
        foreach (Page page in document.GetPages())
        {
            IReadOnlyList<Letter> letters = page.Letters;
            string text = string.Join(string.Empty, letters.Select(x => x.Value));
            string[] strings = text.Split(new[] { "Title:", "Date:", "Time:", "Visit us:" }, StringSplitOptions.None);
            for (int i = 1; i < strings.Length - 3; i += 3)
            {
                ProcessSingleTicket(result, strings, i);
            }
        }
        return result;
    }

    private static void ProcessSingleTicket(List<string> result, string[] strings, int i)
    {
        string name = strings[i];
        var date = DateOnly.Parse(strings[i + 1]);
        var time = TimeOnly.Parse(strings[i + 2]);
        string line = $"{name,-30} | {date.ToString(),-11} | {time.ToString()}";
        result.Add(line);
    }
}

public interface IFileWriter
{
    void WriteTo(string content, params string[] pathParts);
}

public class FileWriter : IFileWriter
{
    public void WriteTo(string content, params string[] pathParts)
    {
        var resultPath = Path.Combine(pathParts);
        File.WriteAllText(resultPath, content);
        Console.WriteLine("Result saved to the file: " + resultPath);
    }
}


//using System.Globalization;

//string date = "1/2/2023";

//CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

//var usDate = DateTime.Parse(date);

//Console.WriteLine(usDate.ToString());

