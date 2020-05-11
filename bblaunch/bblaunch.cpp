
#include <string>
#include <Windows.h>

static const char* bb_err =
"Error when creating BlitzIDE process. Please make sure ide.exe is inside the \"bin\" folder.";

static std::string getAppDir()
{
	char buffer[MAX_PATH];
	std::string t = std::string(buffer, GetModuleFileName(NULL, buffer, MAX_PATH));
	int n = t.find_last_of('\\');
	if(n != std::string::npos) t = t.substr(0, n); //Remove filename from the path and return it
	return t;								  //Blitz3D doesnt like filenames in his path...
}

static void fail(const char* p)
{
	::MessageBox(0, p, "Blitz Error", MB_SETFOREGROUND | MB_TOPMOST | MB_ICONERROR);
	ExitProcess(-1);
}

int _stdcall WinMain(HINSTANCE inst, HINSTANCE prev, char* cmd, int show)
{
	std::string t = getAppDir();
	std::string idePath = "\\bin\\ide.exe ";

	putenv(("blitzpath=" + t).c_str());
	SetCurrentDirectory(t.c_str());
	t += idePath + cmd;

	STARTUPINFO startupInfo;
	PROCESS_INFORMATION processInfo;
	ZeroMemory(&startupInfo, sizeof(startupInfo)); startupInfo.cb = sizeof(startupInfo);

	if(!CreateProcess(0, (char*)t.c_str(), 0, 0, 0, 0, 0, 0, &startupInfo, &processInfo))
	{
		fail(bb_err);
	}

	WaitForInputIdle(processInfo.hProcess, INFINITE);

	CloseHandle(processInfo.hProcess);
	CloseHandle(processInfo.hThread);

	return 0; //Success!
}
