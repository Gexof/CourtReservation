using System;

public  class Court /*: AuthService*/
{

    //Attribute
    public int CourtId { get; set; }

    public string Description { get; set; }

    public string Type { get; set; }
    public Court()
    {
            
    }

    //Parametarized Constructor
    public Court(int CourtId , string Description , string Type)
    {
        this.CourtId = CourtId ;
        this.Description = Description ;
        this.Type = Type ;
    }
    //public abstract string ShowCollection(string collection);

    public Court(int CourtId)
    {
        this.CourtId = CourtId;
    }

}