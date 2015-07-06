lzl.exe : datacontroler.module test.cs
	csc /target:exe /out:lzl.exe test.cs /addmodule:datacontroler.module
datacontroler.module : datacontoler.cs lsy.module ly.module hanhan.module
	csc /target:module /out:datacontroler.module datacontoler.cs /r:System.Data.SQlite.dll /addmodule:lsy.module /addmodule:ly.module /addmodule:hanhan.module
lsy.module : lsy.cs
	csc /target:module /out:lsy.module lsy.cs /r:System.Data.SQlite.dll
ly.module : ly.cs
	csc /target:module /out:ly.module ly.cs /r:System.Data.SQlite.dll
hanhan.module : hanhan.cs
	csc /target:module /out:hanhan.module hanhan.cs /r:System.Data.SQlite.dll