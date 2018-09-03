#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");

	signed char a, b, Signsum;
	unsigned char una, unb, Unsignsum;

	puts("");
	
	a = 141;
	b = 129;
	una = a;
	unb = b;
	
	_asm {
		mov al, a;
		add al, b
		mov Signsum, al
		// ; This is Unsingn char 
		mov bl, una;
		add bl, unb
		mov Unsignsum, bl
	}

	printf("Sign %i + %i = % i\n", a , b, Signsum);		// Singn char output
	printf("Unsign %i + %i = % i", una, unb, Unsignsum);	//Unsingn char output 

	cout << endl;
	int x;
	cin >> x;
	getchar();
	getchar();
	return 0;
}

