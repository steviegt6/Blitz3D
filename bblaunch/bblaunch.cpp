
#define _HAS_STD_BYTE 0 //What this does is tell the compiler that there is no std::byte
#include <string>		//std::byte is a new feature from C++17 that is used to store bytes.
#include <Windows.h>	//Blitz3D uses the keyword "byte", and as it uses the namespace std,
						//the compiler thinks its referencing std::byte, giving an error.

using namespace std;

static const char *bb_err=
"Error when creating Blitz3D process.";


static string getAppDir(){
	char buff[MAX_PATH];
	if (GetModuleFileName(0, buff, MAX_PATH)) {
		string t = buff;
		int n = t.find_last_of('\\');
		if (n != string::npos) t = t.substr(0, n);
		return t;
	}
	return "";
}

static void fail( const char *p ){
	::MessageBox( 0,p,"Blitz Basic Error",MB_SETFOREGROUND|MB_TOPMOST|MB_ICONERROR );
	ExitProcess(-1);
}

int _stdcall WinMain( HINSTANCE inst,HINSTANCE prev,char *cmd,int show ){

	//Ugly hack to get application dir...
	string t=getAppDir();
	putenv( ("blitzpath="+t).c_str() );
	SetCurrentDirectory( t.c_str() );
	t=t+"\\bin\\ide.exe "+cmd;

    STARTUPINFO si;
    PROCESS_INFORMATION pi;
    ZeroMemory(&si,sizeof(si));si.cb=sizeof(si);
	if( !CreateProcess( 0,(char*)t.c_str(),0,0,0,0,0,0,&si,&pi ) ){
		fail(bb_err);
	}

	//wait for BB to start
	WaitForInputIdle( pi.hProcess,INFINITE );

    // Close process and thread handles. 
    CloseHandle( pi.hProcess );
    CloseHandle( pi.hThread );

	return 0;
}
