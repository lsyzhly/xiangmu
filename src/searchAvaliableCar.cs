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