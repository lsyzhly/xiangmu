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
			
			cmd.CommandText="create table contract(carid varchar,driverid varchar,startdate int,enddate int,isagree bool,isvalid bool,PRIMARY KEY(carid,driverid,startdate))";
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
	public void insert(String carid,String driverid,int startdate,int enddata,bool isagree,bool isvalid){
		cmd.CommandText=String.Format("insert into contract values ('{0}','{1}',{2},{3},{4},{5})",carid,driverid,startdate,enddata,isagree?1:0,isvalid?1:0);
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
	public void updateContractIsagree(String carid,String driverid,int startdate,bool isagree){
		cmd.CommandText=String.Format("update Contract set isagree={0} where carid='{1}' and driverid={2} and startdate={3}",isagree?1:0,carid,driverid,startdate);
        cmd.ExecuteNonQuery();
	}
	public void updateContractIsvalid(String carid,String driverid,int startdate,bool isvalid){
		cmd.CommandText=String.Format("update Contract set isvalid={0} where carid='{1}' and driverid={2} and startdate={3}",isvalid?1:0,carid,driverid,startdate);
        cmd.ExecuteNonQuery();
	}
	
	public Driver getDriver(String driverid){
		cmd.CommandText=String.Format("select * from driver where driverid=\'{0}\'",driverid);
		DbDataReader data=cmd.ExecuteReader();
		if(data.Read()){
			String personid=data.GetString(1);
			bool sex=data.GetBoolean(2);
			String name=data.GetString(3);
			String birthday=data.GetString(4);
			String password=data.GetString(5);
			return new Driver(driverid,personid,sex,name,birthday,password);
		}
		return null;
	}
	public Car getCar(String carid)
    {
		cmd.CommandText=String.Format("select * from car where driverid=\'{0}\'",carid);
		DbDataReader data=cmd.ExecuteReader();
		if(data.Read()){
			int caryear=data.GetInt32(1);
			bool avaliable=data.GetBoolean(2);
			bool insurance=data.GetBoolean(3);
			bool yearCheck=data.GetBoolean(4);
			return new Car(carid,caryear,avaliable,insurance,yearCheck);
		}
		return null;
	}
	
	public bool isContract(String driverid,int startdate,int end){
		cmd.CommandText=String.Format("select count() from contract where driverid='{0}' and ((startdate>{1} and startdate<{2})or (enddate>{1} and enddate <{2}))",driverid,startdate,end);
		int n=(int)cmd.ExecuteScalar();
		return n==0;
	}
	public bool isCarAvaliable(Car carid,int startdate,int end){
		return false;
	}
	public void avaliableCar()
	{
		string cmdTemp;
		string nowDate;
		int tempDate;
		DateTime dt = DateTime.Now;
		nowDate=dt.ToString("yyyyMMdd");
		tempDate=int.Parse(nowDate);
		cmdTemp=String.Format("select * from car where carid not in(select carid from contrcst where isvalid=1 and {0}<endDate and isagree=1) and avaliable=1",tempDate);
		//TODO ... 
	}
}