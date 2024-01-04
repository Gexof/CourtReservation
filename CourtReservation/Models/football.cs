using System;


public class football : Court
{
    string surfacetype { set; get; }


    public void update()
    {

    }
    public void add()
    {

    }
    public void delete()
    {

    }
    public void accept()
    {

    }
    public football(string surfacetype, int CourtId, string Description, string Type)
        : base(CourtId, Description, Type)
    {
        this.surfacetype = surfacetype;
    }

}

