#ifndef MULTILANG
#define MULTILANG

namespace MultiLang {
	typedef const char* string;
	typedef const wchar_t* wstring;
#ifdef CHINESE_SIMP // Simplified Chinese
	#include "SimplifiedChinese.cpp"
#elif defined CHINESE_TRAD // Traditional Chinese
	#include "TraditionalChinese.cpp"
#else // English
	#include "English.cpp"
#endif
};

#endif