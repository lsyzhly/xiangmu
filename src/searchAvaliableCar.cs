public void avaliableCar(int end)
{
	string cmdTemp;
	string nowDate;
	int tempDate;
	DateTime dt = DateTime.Now;
	nowDate=dt.ToString("yyyyMMdd");
	tempDate=int.Parse(nowDate);
	end=(end-(end-(end/10000)*10000))/10000;
	cmdTemp=String.Format("select * from car where carid not in(select carid from contract where isvalid=1 and {0}<endDate and isagree=1) and avaliable=1 and (caryear+8)-{1}>=0",tempDate,end);
	//TODO ... 
}