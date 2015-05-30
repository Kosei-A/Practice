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
    strncpy( t, buff, 4 ); //str�̐擪����4������t�ɃR�s�[
    t[4] = '\0';            //���o�������������̍Ō��'\0'������
    printf( "%s\n", t );
    printf("End\n\n");

    strncpy( t, &buff[m-4], 4 ); //str�̍Ōォ��4������t�ɃR�s�[
    t[4] = '\0';            //���o�������������̍Ō��'\0'������
    printf( "%s\n", t );
    printf("End\n\n");


    char s1[] = "Hello World";
    char s2[] = "W";
    char *ret;
    ret = strstr(s1, s2);
    strncpy( t, &s1[ret-s1], 4 ); //W����4������t�ɃR�s�[
    t[4] = '\0';            //���o�������������̍Ō��'\0'������
    printf( "%s\n", t );
    printf("End\n\n");

    return EXIT_SUCCESS;
}
