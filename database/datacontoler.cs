using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Data.SQLite;

public class datacontrol{
	DbConnection connection;
	DbCommand cmd;
    String str;
	public datacontrol(String path){
		bool flag;
		if(File. Exists(path)){
			flag=false;
		}else{
			flag=true;
		}
		SQLiteConnection con = new SQLiteConnection ("Data Source="+path);
        str = path;
        con.Open();
		connection=con;
		cmd=new SQLiteCommand(con);
		if(flag){
			cmd.CommandText="create table driver(driverid varchar PRIMARY KEY,personid varchar not null,sex bool not null,name varchar not null,birthday char(8) not null,password varchar not null)";
			cmd.ExecuteNonQuery();
			
			cmd.CommandText="create table adminstrator (id varchar PRIMARY KEY,password varchar not null)";
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
	public void insert(String carid,String driverid,int startdate,int enddate,bool isagree,bool isvalid){
		cmd.CommandText=String.Format("insert into contract values ('{0}','{1}',{2},{3},{4},{5})",carid,driverid,startdate,enddate,isagree?1:0,isvalid?1:0);
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
            String password = data.GetString(5);
            data.Close();
			return new Driver(driverid,personid,sex,name,birthday,password);
        }
        data.Close();
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
            bool yearCheck = data.GetBoolean(4);
            data.Close();
			return new Car(carid,caryear,avaliable,insurance,yearCheck);
        }
        data.Close();
		return null;
	}
	public bool isDriverContract(String driverid,int startdate,int end){
        cmd.CommandText = String.Format("select count(carid) from contract where driverid='{0}' and isagree=1 and isvalid and NOT (startdate>{2} or enddate<{1})", driverid, startdate, end);
		long n=(long)cmd.ExecuteScalar();
		return n==0;
	}
    public bool isCarContract(String carid, int startdata, int end)
    {
        cmd.CommandText = String.Format("select count(carid) from Car where carid not in (select DISTINCT carid from contract where isvalid=1 and not (startdate>{1} or enddate<{0}) and isagree=1) and carid='{2}' and avaliable=1 and insurancen=1 and yearcheck=1 and (caryear+8)*10000>={1}", startdata, end, carid);
        long a = (long)cmd.ExecuteScalar();
        return a!=0;
    }
	public DataAdapter avaliableCar(int start,int end)
	{
        cmd.CommandText = String.Format(
            "select * from Car where carid not in (select DISTINCT carid from contract where isvalid=1 and not (startdate>{1} or enddate<{0}) and isagree=1) and avaliable=1 and insurancen=1 and yearcheck=1 and (caryear+8)*10000>={1}", start, end);
		//TODO ... 
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
	}
    public DataAdapter getUseCar(String driverid)
    {
        cmd.CommandText = String.Format("select carid,startdate,enddate from contract where driverid='{0}'",driverid);
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
    }
    public DataAdapter getContract(String driverid)
	{
		DateTime now = DateTime.Now;
		String  tmp = now.ToString("yyyyMMdd");
		int date = Convert.ToInt32(tmp);
        cmd.CommandText = String.Format("select * from contract where driverid='{0}' and startdate <={1} and enddate>={1} and isagree==1 and isvalid = 1", driverid, date);
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
	}
    public DataAdapter getContract()
    {
        DateTime now = DateTime.Now;
        String tmp = now.ToString("yyyyMMdd");
        int date = Convert.ToInt32(tmp);
        cmd.CommandText = String.Format("select * from contract where startdate <={0} and enddate>={0} and isagree==1 and isvalid = 1", date);
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
    }
    public DataAdapter getAllContract(String driverid)
	{
        cmd.CommandText = String.Format("select * from contract where driverid = \'{0}\'", driverid);
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
    }
    public DataAdapter getAllContract()
    {
        cmd.CommandText = String.Format("select * from contract");
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
    }
    public DataAdapter getOkContract(String driverid)
    {
        cmd.CommandText = String.Format("select * from contract where driverid = \'{0}\' and isagree=1 and isvalid = 1", driverid);
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
    }
    public DataAdapter getOkContract()
    {
        cmd.CommandText = String.Format("select * from contract where isagree=1 and isvalid = 1");
        return new SQLiteDataAdapter((SQLiteCommand)cmd);
    }
    public String getAdminPassword(String id)
    {
        cmd.CommandText = String.Format("select password from adminstrator where id='{0}'", id);
        return (String)cmd.ExecuteScalar();
    }
}