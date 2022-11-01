#ifndef MULTILANG
#define MULTILANG

namespace MultiLang {
	typedef const char* string;
	typedef const wchar_t* wstring;
#ifdef CHINESE_SIMP
	#include "SimplifiedChinese.cpp"
#elif defined CHINESE_TRAD
	#include "TraditionalChinese.cpp"
#else
	#include "English.cpp"
#endif
};

#endif