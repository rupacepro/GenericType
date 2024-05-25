string filePath = @"C:\Users\rupac\Desktop\sampleData.csv";

var csvReader = new CSVReader();
var data = csvReader.Read(filePath);
Console.WriteLine(data);
Console.ReadKey();

public class CSVReader
{
    public CSVData Read(string filePath)
    {
        using StreamReader reader = new StreamReader(filePath);
        string[] columns = reader.ReadLine().Split(",");
        var rows = new List<string[]> { };

        while (!reader.EndOfStream)
        {
            var row = reader.ReadLine().Split(",");
            rows.Add(row);
        }
        return new CSVData(columns, rows);
    }

}

public class CSVData
{
    public string[] Column { get; }
    public IEnumerable<string[]> Rows { get; }

    public CSVData(string[] column, IEnumerable<string[]> rows)
    {
        Column = column;
        Rows = rows;
    }

}
