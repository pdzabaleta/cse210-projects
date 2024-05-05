public class Entry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }

    public Entry(string prompt, string response)
    {
        Date = DateTime.Now;
        Prompt = prompt;
        Response = response;
    }

    public string GetFormattedDateTime()
    {
        return Date.ToString("yyyy-MM-dd HH:mm:ss");
    }
}