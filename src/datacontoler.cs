using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Data.SQLite;

class datacontrol{
	DbConnection connection;
	DbCommand cmd;
	public datacontrol(String path){
		bool flag;
		if(File. Exists(path)){
			flag=false;
		}else{
			flag=true;
		}
		SQLiteConnection con = new SQLiteConnection ("Data Source="+path);
        con.Open();
		connection=con;
		cmd=new SQLiteCommand(con);
		if(flag){
			cmd.CommandText="create table driver(driverid varchar PRIMARY KEY,personid varchar not null,sex bool not null,name varchar not null,birthday char(8) not null,password varchar not null)";
			cmd.ExecuteNonQuery();
			
			cmd.CommandText="create table adminstrator (id varcharPRIMARY KEY,password varchar not null)";
			cmd.ExecuteNonQuery();
			cmd.CommandText="insert into adminstrator values(\'adminstrator\',\'1234\')";
			cmd.ExecuteNonQuery();
			
			cmd.CommandText="create table car(carid varchar primary key,caryear int,avaliable bool,insurancen bool,yearcheck bool)";
			cmd.ExecuteNonQuery();
			//TODO create the table
		}
	}
	public void insert(String driverid,String personid,bool sex,String name,String birthday,String password){
		cmd.CommandText=String.Format("insert into driver values ('{0}','{1}',{2},'{3}','{4}','{5}')",driverid,personid,sex?1:0,name,birthday,password);
		cmd.ExecuteNonQuery();
	}
	public void insert(String id,String password){
		cmd.CommandText=String.Format("insert into adminstrator values ('{0}','{1}')",id,password);
		cmd.ExecuteNonQuery();
	}
	public void insert(String theCarid,int theCaryear,bool theAvaliable,bool theInsurance,bool theYearCheck)
	{   
	    String cmdTemp;
		cmdTemp=String.Format("insert into car values ('{0}',{1},{2},{3},{4})",theCarid,theCaryear,theAvaliable?1:0,theInsurance?1:0,theYearCheck?1:0);
		cmd.CommandText = cmdTemp;
        cmd.ExecuteNonQuery();
	}
	public void updateDriverName(String id,String str){
		cmd.CommandText=String.Format("update driver set name='{0}' where driverid='{1}'",str,id);
		cmd.ExecuteNonQuery();
	}
	public void updateDriverPassword(String id,String str){
		cmd.CommandText=String.Format("update driver set password='{0}' where driverid='{1}'",str,id);
		cmd.ExecuteNonQuery();
	}
	public void updateAdminstratorPassword(String id,String password){
		cmd.CommandText=String.Format("update adminstrator set password='{0}' where id='{1}'",password,id);
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