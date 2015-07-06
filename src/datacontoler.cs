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
			//TODO create the table
		}
	}
	void insert(String driverid,String personid,bool sex,String name,String birthday,String password){
		cmd.CommandText=String.Format("insert into driver values ('{0}','{1}',{2},'{3}','{4}','{5}')",driverid,personid,sex,name,birthday,password);
		cmd.ExecuteNonQuery();
	}
	void updateDriverName(string str){
		name=str;
	}
	void updateDriverPassword(string str){
		password=str;
	}
}