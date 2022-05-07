OpenCC "../../../opencc/s2t.json" ; 設置OpenCC配置
DownloadFile("https://scpcbgame.cn/changelog.txt", "changelog.txt") ; 下載網絡文件，詳見DownloadFile
Local ChangeLogFile = OpenFile("changelog.txt")
While Not Eof(ChangeLogFile)
	l$ = ReadLine(ChangeLogFile)
	Print l ; 逐行掃描並打印
	If l="" Then Exit ; 如果此行為空則退出循環
Wend
CloseFile(ChangeLogFile)
DeleteFile("changelog.txt") ; 刪除文件
WaitKey