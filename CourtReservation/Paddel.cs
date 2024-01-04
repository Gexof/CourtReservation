using System;

public class Paddel : Court
{
    bool hasGlassWalls { set; get; }

    public void Rerserv()
    {

    }
    public void ShowReserved()
    {

    }

    public Paddel(bool hasGlassWalls, int CourtId, string Description, string Type)
        : base(CourtId, Descreption, Type)
    {
        this.hasGlassWalls = hasGlassWalls;
    }

}