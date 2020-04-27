
#include <string>
#include <Windows.h>

using namespace std;

static const char* bb_err =
"Error when creating Blitz3D process.";


/*static string getAppDir()  --OLD GETAPPDIR
{
	char buff[MAX_PATH];
	if(GetModuleFileName(0, buff, MAX_PATH))
	{
		string t = buff;
		int n = t.find_last_of('\\');
		if(n != string::npos) t = t.substr(0, n);
		return t;
	}
	return "";
}
*/

//Made it more compact.
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
	putenv(("blitzpath=" + t).c_str());
	SetCurrentDirectory(t.c_str());
	t = t + "\\bin\\ide.exe " + cmd;

	STARTUPINFO si;
	PROCESS_INFORMATION pi;
	ZeroMemory(&si, sizeof(si)); si.cb = sizeof(si);

	if(!CreateProcess(0, (char*)t.c_str(), 0, 0, 0, 0, 0, 0, &si, &pi))
	{
		fail(bb_err);
	}

	//wait for BB to start
	WaitForInputIdle(pi.hProcess, INFINITE);

	// Close process and thread handles. 
	CloseHandle(pi.hProcess);
	CloseHandle(pi.hThread);

	return 0;
}
