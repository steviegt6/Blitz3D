
#ifndef CONFIG_H
#define CONFIG_H

#define BASE_VER	1118

#ifdef	PRO
#define	PRO_F	0x010000
#else
#define	PRO_F	0
#endif

#define VERSION		(BASE_VER|PRO_F)

#endif
