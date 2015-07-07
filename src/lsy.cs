using System;
 public class Driver{
	String driverid;
	String personid;
	bool sex;
	String name;
	String birthday;
	public String password;
	public Driver(String did,String pid,bool se,String na,String bith,String pass){
		driverid=did;
		personid=pid;
		sex=se;
		name=na;
		birthday=bith;
		password=pass;
	}
	public bool isContract(int startdate,int enddate){
		return false;
	}
}