
#include "stdafx.h"
#include "prefs.h"
#include "libs.h"
#include "resource.h"

#include <mmsystem.h>

char _credits[] =
"\r\n"
"Programming and design: Mark Sibly\r\n"
"Keeping this thing alive: juanjp600, Saalvage, VaneBrain, AestheticalZ and ZiYueCommentary\r\n"
".INI loading using a modified version of \"IniPP\", originally by Matthias C. M. Troffaes\r\n"
"Documentation: Mark Sibly, Simon Harrison, Paul Gerfen, Shane Monroe and the Blitz Doc Team\r\n"
"Testing and support: James Boyd, Simon Armstrong and the Blitz Dev Team\r\n"
"Image loader courtesy of FreeImage by Floris van den berg\r\n"
#ifdef OPENCC
"OpenCC extension is based on OpenCC\r\n"
"´ËBlitz3D TSS°üº¬OpenCC½M¼þ£¡\r\n";
#else
;
#endif

class Dialog : public CDialog {
	bool _quit;
public:
	Dialog() :_quit(false) {}

	afx_msg void OnOK() {
		_quit = true;
	}

	void wait() {
		_quit = false;
		MSG msg;
		while(!_quit && GetMessage(&msg, 0, 0, 0)) {
			if(!AfxGetApp()->PreTranslateMessage(&msg)) {
				TranslateMessage(&msg);
				DispatchMessage(&msg);
			}
		}
		EndDialog(0);
	}

	void wait(int n) {
		int _expire = (int)timeGetTime() + n;
		for(;;) {
			int tm = _expire - (int)timeGetTime();
			if(tm < 0) tm = 0;
			MsgWaitForMultipleObjects(0, 0, false, tm, QS_ALLEVENTS);

			MSG msg;
			if(PeekMessage(&msg, 0, 0, 0, PM_REMOVE)) {
				if(!AfxGetApp()->PreTranslateMessage(&msg)) {
					TranslateMessage(&msg);
					DispatchMessage(&msg);
				}
			}
			if(!tm) return;
		}
	}
};

void aboutBlitz() {

	AfxGetMainWnd()->EnableWindow(0);

	Dialog about;

	about.Create(IDD_ABOUT);

	std::string credits;

	credits += _credits;

	about.GetDlgItem(IDC_CREDITS)->SetWindowText(credits.c_str());

	std::string t = "";

	t += "Blitz3D";

#ifdef OPENCC
	t += " - with OpenCC extension\n\n";
#else
	t += " - Release Version\n\n";
#endif

	about.GetDlgItem(IDC_PRODUCT)->SetWindowText(t.c_str());

	t = "Runtime V" + itoa((VERSION & 0xffff) / 1000) + "." + itoa((VERSION & 0xffff) % 1000);

	about.GetDlgItem(IDC_VERSION)->SetWindowText(t.c_str());

	about.wait();
	about.EndDialog(0);
	AfxGetMainWnd()->EnableWindow(1);
}

