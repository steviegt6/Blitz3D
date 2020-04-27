
#include <string>
#include <Windows.h>

using namespace std;

static const char* bb_err =
"Error when creating Blitz3D process.";

static string getAppDir()
{
	char buffer[MAX_PATH];
	string t = string(buffer, GetModuleFileName(NULL, buffer, MAX_PATH));
	int n = t.find_last_of('\\');
	if(n != string::npos) t = t.substr(0, n); //Remove filename from the path and return it
	return t;								  //Blitz3D doesnt like filenames in his path...
}

static void fail(const char* p)
{
	::MessageBox(0, p, "Blitz Basic Error", MB_SETFOREGROUND | MB_TOPMOST | MB_ICONERROR);
	ExitProcess(-1);
}

int _stdcall WinMain(HINSTANCE inst, HINSTANCE prev, char* cmd, int show)
{
	//We really need a better way to get the application path...
	//Maybe with C++17's new std::filesystem::path class?
	string t = getAppDir();
	string idePath = "\\bin\\ide.exe ";

	putenv(("blitzpath=" + t).c_str());
	SetCurrentDirectory(t.c_str());
	t += idePath + cmd;

	STARTUPINFO startupInfo;
	PROCESS_INFORMATION processInfo;
	ZeroMemory(&startupInfo, sizeof(startupInfo)); startupInfo.cb = sizeof(startupInfo);

	if(!CreateProcess(0, (char*)t.c_str(), 0, 0, 0, 0, 0, 0, &startupInfo, &processInfo))
	{
		//Crash the application.
		fail(bb_err);
	}

	//Wait for BB to start...
	WaitForInputIdle(processInfo.hProcess, INFINITE);

	//Close process and thread handles. 
	CloseHandle(processInfo.hProcess);
	CloseHandle(processInfo.hThread);

	return 0; //Success
}
