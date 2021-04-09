#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char** argv)
{
	printf("hello librpa!\n");

	char line[1024] = { '\0' };
	fgets(line, sizeof(line), stdin);

	return 0;
}