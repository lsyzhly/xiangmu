using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Data.SQLite;

class datacontrol{
	DbConnection connection;
	DbCommand cmd;
	public datacontrol(string path){
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
			//TODO create the table
		}
	}
}