using System;
public class Car
{
	private String carid;
	private int caryear;
	private bool avaliable;
	private bool insurance;
	private bool yearCheck;
	public Car(String theCarid,int theCarYear,bool theAvaliable,bool theInsurance,bool theYearCheck)
	{
		carid=theCarid;
		caryear=theCarYear;
		avaliable=theAvaliable;
		insurance=theInsurance;
		yearCheck=theYearCheck;
	}
}
