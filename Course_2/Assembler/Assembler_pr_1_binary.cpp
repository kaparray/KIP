// ConsoleApplication2.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");
	short a, b, summ, rez;
	short *p, *q, *g;
	cout << "Enter a: ";
	cin >> a;
	cout << "Enter b: ";
	cin >> b;
	summ = a + b;
	p = &a; q = &b; g = &summ;
	puts("");
	std::cout << p << "\n";
	std::cout << q << "\n";
	std::cout << g << "\n";

	//    std::cout << std::endl;
	//    std::cout << "summ= " << a + b << std::endl;
	_asm{
		mov ax, a;
		mov bx, b;
		and ax, 10011101b
		and bx, 11111001b
		mov a, ax;
		mov b, bx;
	}

	cout << "a= " << a << " b = " << b;

	cout << endl;
	int x;
	cin >> x;
	return 0;
}

