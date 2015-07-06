lzl.exe : datacontroler
	csc /target:exe /out:lzl.exe test.cs /addmodule:datacontroler.module
datacontroler : datacontoler1.cs
	csc /target:module /out:datacontroler.module datacontoler.cs /r:System.Data.SQLite.dll