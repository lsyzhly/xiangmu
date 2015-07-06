using System;
class car
{
	private String carid;
	private int caryear;
	private bool avaliable;
	private bool insurance;
	private bool yearCheck;
	public car(String theCarid,int theCarYear,bool theAvaliable,bool theInsurance,bool theYearCheck)
	{
		carid=theCarid;
		caryear=theCarYear;
		avaliable=theAvaliable;
		insurance=theInsurance;
		yearCheck=theYearCheck;
	}
}
public Driver getCar(String driverid)
   {
		cmd.CommandText=String.Format("select * from car where driverid=\'{0}\'",carid);
		DbDataReader data=cmd.ExecuteReader();
		if(data.Read()){
			String caryear=data.GetInt32(1);
			bool avaliable=data.GetBoolean(2);
			bool insurance=data.GetBoolean(3);
			bool yearCheck=data.GetBoolean(4);
			return new car(carid,caryear,avaliable,insurance,yearCheck);
		}
		return null;
	}