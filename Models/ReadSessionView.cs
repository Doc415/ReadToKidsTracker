namespace ReadToKidsTracker.Models;

public class ReadSessionView
{
    public int Id { get; set; }
    public string BookName { get; set; }
    public int StartPage { get; set; }
    public int EndPage { get; set; }
    public string Date { get; set; } //using string to view data , it is already validated before inserted to db
    public int Duration { get; set; }
    public string? Comments { get; set; }
    public int TotalPages { get; set; }
}

