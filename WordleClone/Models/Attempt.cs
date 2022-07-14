using System;
using SQLite;

namespace WordleClone.Models;

public class Attempt
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public int NumLetters { get; set; }
    public int NumGuesses { get; set; }
    public bool Succesful { get; set; }
    public string Answer { get; set; }
    public int TurnsNeeded { get; set; }
    public string WordsUsed { get; set; }
}

