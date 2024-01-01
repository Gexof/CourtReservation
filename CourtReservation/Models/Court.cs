using System;

public abstract class Court
{
    public int CourtId { get; set; }

    public string Descreption { get; set; }

    public string Type { get; set; }

    public Court(int CourtId , string Description , string Type)
    {
        this.CourtId = CourtId ;
        this.Descreption = Description ;
        this.Type = Type ;
    }
    public abstract string ShowCollection(string collection);
}