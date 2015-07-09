using System;
public class Contract{
	String driverid;
	String carid;
	int startdate;
	int enddate;
	bool isagree;
	bool isvalid;
	public Contract(String cid,String did,int std,int endd,bool isa,bool isv)
	{
		carid = cid;
		driverid = did;
		startdate = std;
		enddate = endd;
		isagree = isa;
		isvalid = isv;
	
	}
}