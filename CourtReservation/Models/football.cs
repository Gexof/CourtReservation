using System;

public class football:Court
{
	string surfacetype { set; get; }


	public void update()
	{

	}
	public void add()
	{

	}
	public void delet()
	{

	}

	public void accept()
	{

	}


	public football( string surfacetype,int CourtId,string Descreption,string Type)
		:base(CourtId, Descreption, Type)
	{
		this.surfacetype = surfacetype;
	}
}
