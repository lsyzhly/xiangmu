class test{
	public static void Main(string[] argvs){
		datacontrol a=new datacontrol("asd.data");
		a.insert("adm","cjwddtc");
		a.updateAdminstratorPassword("adm","1234");
		a.insert("123","456",true,"789","asd","fgh");
		//a.updateDriverName("123",)
	}
}