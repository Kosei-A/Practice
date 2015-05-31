/*---------------------------------------------------
/ Name:        HelloWorld
/ Purpose:     Practice
/ version:     1.0
/ Author:      Kosei.A
/
/ Created:     26/5/2015
/ Copyright:   Kosei.A
/ Licence:     your licence
/--------------------------------------------------- */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
	printf("----- 1.1 only 1 time -----\n");
	printf("Hello World\n----- End -----\n\n"); /* prints !!!Hello World!!! */


	printf("----- 1.2 loop 5 times -----\n");
	int i;
	for (i = 1; i <= 5; i++){
	  printf("Hello World\n");
	}
    printf("----- End -----\n\n");


	printf("----- 1.3 print each characters -----\n");
    int j;
    int m;
    char buff[] = "Hello World";
    m = strlen(buff);
    for (j = 0; j <= m; j++) {
		printf("%c \n", buff[j]);
    }
    printf("----- End -----\n\n");

	printf("----- 1.4 print [l] character only -----\n");
    for (j = 0; j <= m; j++) {
    	if (buff[j] == 'l'){
    		printf("%c \n", buff[j]);
    	}
    }
    printf("----- End -----\n\n");

	printf("----- 1.5 print first 4 characters -----\n");
    char t[4];
    strncpy( t, buff, 4 ); //
    t[4] = '\0';            //
    printf( "%s\n", t );
    printf("----- End -----\n\n");

	printf("----- 1.6 print last 4 characters -----\n");
    strncpy( t, &buff[m-4], 4 ); //s
    t[4] = '\0';            //
    printf( "%s\n", t );
    printf("----- End -----\n\n");

	printf("----- 1.7 print 4 characters from [W] -----\n");
    char s1[] = "Hello World";
    char s2[] = "W";
    char *ret;
    ret = strstr(s1, s2);
    strncpy( t, &s1[ret-s1], 4 ); //
    t[4] = '\0';            //
    printf( "%s\n", t );
    printf("----- End -----\n\n");

    return EXIT_SUCCESS;
}
