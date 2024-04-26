
var app = new GameDataParser();
Logger logger = new Logger("log.txt");
try
{
    app.Run();
}
catch(Exception ex)
{
    Console.WriteLine("Sorry! The application has experienced an unexpected error and will have to be closed.");
    Console.WriteLine(ex.Message);
    logger.Log(ex);
} 

Console.WriteLine("Press any key to close.");
Console.ReadKey();
