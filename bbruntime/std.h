#ifndef STD_H
#define STD_H

#include <Windows.h>

#include "constants.h"
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

#define ErrorLog(function, log) if (debug) { RTEX(log) } else { errorlog = std::format("{0}: {1}", function, log); }

#endif