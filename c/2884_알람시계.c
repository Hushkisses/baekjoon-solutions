#include <stdio.h>

int main(void)
{
	int hour = 0;
	int min = 0;
	int Newmin = 0;
	scanf("%d %d", &hour, &min);

	min -= 45;
	
	if (min < 0)
	{
		hour -= 1;
		if (hour < 0)
			hour = 23;
		Newmin = 60 + min;
	} 
	if (min == 0)
	{
		Newmin = min;
	}
	if (min > 0)
		Newmin = min;


	

	printf("%d %d", hour, Newmin);
		



}