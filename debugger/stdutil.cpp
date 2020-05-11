
#include "stdafx.h"

int atoi( const string &s ){
	return atoi( s.c_str() );
}

double atof( const string &s ){
	return atof( s.c_str() );
}

string itoa( int n ){
	char buff[32];itoa( n,buff,10 );
	return string( buff );
}

/////////////
//By FLOYD!//
/////////////
string ftoa( float n ){

	static const int digits=6;

	int eNeg = -4, ePos = 8;	// limits for e notation.

	char buffer[50]; // from MSDN example, 25 would probably suffice
	string t;
	int dec, sign;

	if ( _finite( n ) ){		
		t = _ecvt( n, digits, &dec, &sign );

		if ( dec <= eNeg + 1 || dec > ePos ){

			_gcvt( n, digits, buffer );
			t = buffer;
			return t;
		}
		
		// Here is the tricky case. We want a nicely formatted
		// number with no e-notation or multiple trailing zeroes.
	
		if ( dec <= 0 ){

			t = "0." + string( -dec, '0' ) + t;
			dec = 1;	// new location for decimal point

		}
		else if( dec < digits ){

			t = t.substr( 0, dec ) + "." + t.substr( dec );

		}
		else{

			t = t + string( dec - digits, '0' ) + ".0";
			dec += dec - digits;

		}
	
		// Finally, trim off excess zeroes.

		int dp1 = dec + 1, p = t.length();	
		while( --p > dp1 && t[p] == '0' );
		t = string( t, 0, ++p );

		return sign ? "-" + t : t;

	}	// end of finite case

	if ( _isnan( n ) )	return "NaN";
	if ( n > 0.0 )		return "Infinity";
	if ( n < 0.0 )		return "-Infinity";

	abort();
}

string tolower( const string &s ){
	string t=s;
	for( int k=0;k<t.size();++k ) t[k]=tolower(t[k]);
	return t;
}

string toupper( const string &s ){
	string t=s;
	for( int k=0;k<t.size();++k ) t[k]=toupper(t[k]);
	return t;
}

string fullfilename( const string &t ){
	char buff[MAX_PATH+1],*p;
	GetFullPathName( t.c_str(),MAX_PATH,buff,&p );
	return string(buff);
}

string filenamepath( const string &t ){
	char buff[MAX_PATH+1],*p;
	GetFullPathName( t.c_str(),MAX_PATH,buff,&p );
	if( !p ) return "";
	*p=0;return string(buff);
}

string filenamefile( const string &t ){
	char buff[MAX_PATH+1],*p;
	GetFullPathName( t.c_str(),MAX_PATH,buff,&p );
	if( !p ) return "";
	return string( p );
}
