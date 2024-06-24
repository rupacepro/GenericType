const string TicketFolder = @"C:\Users\rupac\Desktop\Second Semester\c#\practice\GameDataParser\StringManipulation\TicketDataAggregator\Tickets";

try
{
    var ticketAggregator = new TicketAggregator(TicketFolder, new FileWriter());
    ticketAggregator.Run();
}
catch (Exception ex)
{
    Console.WriteLine("An exception occured. Exceptioin message: " + ex.Message);
}

Console.ReadKey();
