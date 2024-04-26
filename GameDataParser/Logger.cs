public class Logger
{
    private string _fileName;
    public Logger(string filename)
    {
        _fileName = filename;
    }

    public void Log(Exception ex)
    {
        string logging_message = 
$@"{DateTime.Now}
Exception message: {ex.Message}
stack trace: {ex.StackTrace}

";
        File.AppendAllText(_fileName, logging_message);

    }
}