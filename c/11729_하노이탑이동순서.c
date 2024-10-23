#include <stdio.h>
#include <string.h>
#include <math.h>

int stack = 0;

void HanoiTower(int n, char from, char mid, char to)
{
	if (n == 1)
	{
		printf("%c %c\n", from, to);
		return;
	}
	HanoiTower(n - 1, from, to, mid);
	printf("%c %c\n", from, to);
	HanoiTower(n - 1, mid, from, to);
}


int main(void)
{
	int n = 0;
	int K;
	
	scanf("%d", &n);
	K = pow(2, n) - 1;
	printf("%d\n", K);
	HanoiTower(n, '1', '2', '3');

}