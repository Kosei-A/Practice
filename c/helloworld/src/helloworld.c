/*
 ============================================================================
 Name        : helloworld.c
 Author      : Kosei.A
 Version     : 1.0
 Copyright   : Your copyright notice
 Description : Hello World in C, Ansi-style
 ============================================================================
 */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>

int main(void) {
	printf("Hello World\nEnd\n\n"); /* prints !!!Hello World!!! */

	int i;
	for (i = 1; i <= 5; i++){
	  printf("Hello World\n");
	}
    printf("End\n\n");

    int j;
    int m;
    char buff[] = "Hello World";
    m = strlen(buff);

    for (j = 0; j <= m; j++) {
		printf("%c \n", buff[j]);
    }
    printf("End\n\n");

    for (j = 0; j <= m; j++) {
    	if (buff[j] == 'l'){
    		printf("%c \n", buff[j]);
    	}
    }
    printf("End\n\n");

    char t[4];
    strncpy( t, buff, 4 ); //strの先頭から4文字をtにコピー
    t[4] = '\0';            //取り出した文字数分の最後に'\0'を入れる
    printf( "%s\n", t );
    printf("End\n\n");

    strncpy( t, &buff[m-4], 4 ); //strの最後から4文字をtにコピー
    t[4] = '\0';            //取り出した文字数分の最後に'\0'を入れる
    printf( "%s\n", t );
    printf("End\n\n");


    char s1[] = "Hello World";
    char s2[] = "W";
    char *ret;
    ret = strstr(s1, s2);
    strncpy( t, &s1[ret-s1], 4 ); //Wから4文字をtにコピー
    t[4] = '\0';            //取り出した文字数分の最後に'\0'を入れる
    printf( "%s\n", t );
    printf("End\n\n");

    return EXIT_SUCCESS;
}
