#include "std.h"
#include "bbsys.h"

bool debug;
gxRuntime* gx_runtime;
std::string&& errorlog = ""; // magic rvalue!