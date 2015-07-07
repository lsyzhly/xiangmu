lzl.exe : test.cs datacontroler.dll
	csc /target:exe /out:lzl.exe /r:datacontroler.dll test.cs
datacontroler.dll : datacontoler.cs lsy.cs ly.cs hanhan.cs
	csc /target:library /out:datacontroler.dll datacontoler.cs ly.cs lsy.cs hanhan.cs /r:../System.Data.SQlite.dll