using System;
class test{
	public static void Main(string[] argvs){
		datacontrol a=new datacontrol("asd.data");
		a.insert("H12345",2013,true,true,true);
		a.insert("C12345",2013,true,true,true);
		a.insert("J12345",2013,false,true,true);
		a.insert("G12345",2011,true,true,true);
		a.insert("M123","123",true,"Amy","19950125","1234");
		a.insert("M456","456",false,"Tom","19941212","5678");
		a.insert("M789","789",false,"kitty","19941212","0789");
		a.insert("H12345","M123",20101020,20151020,true,true);
		a.insert("G12345","M456",20121020,20151020,false,true);
		a.insert("H12345","M123",20151020,20171020,false,true);
		a.insert("G12345","M789",20151020,20171020,true,true);
		a.avaliableCar(2020);
		a.insert("J12345","H12345",20121010,20151010,true,true);
		a.getContract("H12345");
		Console.Read();
		
	}
}