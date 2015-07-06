using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Data.SQLite;
class datacontroler
{

		public void carCreate()
	{
		String cmdTemp;
		cmdTemp="create table car(carid varchar primary key,caryear int,avaliable bool,insurancen bool,yearcheck bool)";
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
	public void insertCar(String theCarid,int theCaryear,bool theAvaliable,bool theInsurance,bool theYearCheck)
	{   
	    String cmdTemp;
		cmdTemp=String.Format("insert into car values ('{0}',{1},{2},{3},{4})",theCarid,theCaryear,theAvaliable?1:0,theInsurance?1:0,theYearCheck?1:0);
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
	public void searchCar(String theCarid)
	{
		String cmdTemp;
		cmdTemp=String.Format("select *from car where carid='theCarid'",theCarid);
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
	public void updateAvaliable(String theCarid,bool theAvaliable)
	{
		String cmdTemp;
		cmdTemp=String.Format("update car set avaliable={0} where carid='{1}'",theAvaliable?1:0,theCarid);
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
	public void updateInsurance(String theCarid,bool theInsurance)
	{
		String cmdTemp;
		cmdTemp=String.Format("update car set insurancen={0} where carid='{1}'",theInsurance?1:0,theCarid);
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
	public void updateYearCheck(String theCarid,bool theYearCheck)
	{
		String cmdTemp;
		cmdTemp=String.Format("update car set yearcheck={0} where carid='{1}'",theYearCheck?1:0,theCarid);
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
}