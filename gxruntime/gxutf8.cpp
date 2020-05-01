#include "std.h"
#include "gxutf8.h"

int UTF8::measureCodepoint(char chr) {
    if ((chr & 0x80) == 0x00) {
        //first bit is 0: treat as ASCII
        return 1;
    }

    //first bit is 1, number of consecutive 1 bits at the start is length of codepoint
    int len = 0;
    while (((chr >> (7 - len)) & 0x01) == 0x01) {
        len++;
    }
    return len;
}

int UTF8::decodeCharacter(const char* buf, int index) {
    int codepointLen = measureCodepoint(buf[index]);

    if (codepointLen == 1) {
        return buf[index];
    } else {
        //decode first byte by skipping all bits that indicate the length of the codepoint
        int newChar = buf[index] & (0x7f >> codepointLen);
        for (int j = 1; j < codepointLen; j++) {
            //decode all of the following bytes, fixed 6 bits per byte
            newChar = (newChar << 6) | (buf[index + j] & 0x3f);
        }
        return newChar;
    }
}

int UTF8::length(const std::string& str) {
    int utf8Len = 0;
    for (int i=0;i<str.size();) {
        utf8Len++;
        i += measureCodepoint(str[i]);
    }
    return utf8Len;
}

int UTF8::find(const std::string& str, const std::string& sstr, int from) {
    int utf8Index = 0;
    int bytesFrom = -1;
    for (int i=0;i<str.size();) {
        if (from == utf8Index) {
            bytesFrom = i;
            break;
        }
        utf8Index++;
        i += measureCodepoint(str[i]);
    }
    if (bytesFrom < 0) { return -1; }
    int bytesResult = str.find(sstr,bytesFrom);
    int result = -1;
    for (int i=bytesFrom;i<str.size();) {
        if (bytesResult == i) {
            result = utf8Index;
            break;
        }
        utf8Index++;
        i += measureCodepoint(str[i]);
    }
    return result;
}

std::string UTF8::substr(const std::string& str, int start, int length) {
    int utf8Index = 0;
    int bytesStart = str.size();
    int bytesLength = str.size();
    for (int i=0;i<str.size();) {
        if (start == utf8Index) {
            bytesStart = i;
        }
        if ((start+length) == utf8Index) {
            bytesLength = i - bytesStart;
            break;
        }
        utf8Index++;
        i += measureCodepoint(str[i]);
    }
    return str.substr(bytesStart, bytesLength);
}

std::wstring UTF8::convertToUtf16(const std::string& str) {
    std::wstring result = L"";

    for (int i=0;i<str.size();) {
        result.push_back(decodeCharacter(str.c_str(),i));
        i+=measureCodepoint(str[i]);
    }

    return result;
}
