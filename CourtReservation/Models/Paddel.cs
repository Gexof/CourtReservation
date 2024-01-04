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

<<<<<<< HEAD:CourtReservation/Paddel.cs
    public Paddel(bool hasGlassWalls, int CourtId, string Description, string Type)
        : base(CourtId, Descreption, Type)
    {
        this.hasGlassWalls = hasGlassWalls;
    }
=======
	public Paddel(bool hasGlassWalls, int CourtId, string Descreption, string Type)
		: base(CourtId, Descreption, Type)
	{
		this.hasGlassWalls = hasGlassWalls;
	}
>>>>>>> b8143d2f0d4d516ed13ab2c6d5fb8d0cb4f7eec3:CourtReservation/Models/Paddel.cs

}