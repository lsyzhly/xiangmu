lzl.exe : datacontroler.dll test.cs
	csc /target:exe /out:lzl.exe test.cs /r:datacontroler.dll
datacontroler.dll : datacontoler.cs lsy.cs ly.cs hanhan.cs
	csc /target:library /out:datacontroler.dll datacontoler.cs ly.cs lsy.cs hanhan.cs /r:System.Data.SQlite.dll