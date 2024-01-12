using System;


public class football : Court
{
    string surfacetype { set; get; }


   
    public football(string surfacetype, int CourtId, string Description, string Type)
        : base(CourtId, Description, Type)
    {
        this.surfacetype = surfacetype;
    }

}

