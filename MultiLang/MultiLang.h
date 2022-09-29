#ifndef MULTILANG
#define MULTILANG

#define ENGLISH

namespace MultiLang {
	typedef const char* string;
	typedef const wchar_t* wstring;
#ifdef CHINESE_SIMP
	#undef ENGLISH
	#include "SimplifiedChinese.cpp"
#endif
#ifdef CHINESE_TRAD
	#undef ENGLISH
	#include "TraditionalChinese.cpp"
#endif
#ifdef ENGLISH
	#include "English.cpp"
#endif
};

#endif