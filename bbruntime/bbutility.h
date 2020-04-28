#ifndef BBUTILITY_H
#define BBUTILITY_H

#include <Windows.h>
#include "../stdutil/stdutil.h"

#include <set>
#include <map>
#include <list>
#include <string>
#include <vector>
#include <iostream>
#include <fstream>

#include <cmath>

//INCLUDE USEFUL FUNCTIONS HERE

using namespace std;

static const float dtor = 0.01745329252f; //DEGREES TO RADIANS
static const float rtod = 57.295779513f;  //RADIANS TO DEGREES

float degToRad(float n)
{
	return n * dtor;
}

float radToDeg(float n)
{
	return n * rtod;
}

#endif