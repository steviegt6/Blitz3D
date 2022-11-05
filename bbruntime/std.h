#ifndef STD_H
#define STD_H

#include <Windows.h>

#include "../config/config.h"
#include "../stdutil/stdutil.h"

#include <set>
#include <map>
#include <list>
#include <string>
#include <vector>
#include <iostream>
#include <fstream>

#include <cmath>

#define ErrorLog(function, log) if (debug) { RTEX(log) } else { if(error_logs.size() > 100) error_logs.clear(); error_logs.push_back(std::format("{0}: {1}", function, log)); }

#endif