// ConsoleApplication3.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
using namespace std;


int main()
{
	setlocale(LC_ALL, "rus");
	int a, b,  rez;
	
	cout << "Enter a: ";
	cin >> a;
	cout << "Enter b: ";
	cin >> b;
	
	puts("");
	

	//    std::cout << std::endl;
	//    std::cout << "summ= " << a + b << std::endl;
	_asm {
		mov eax, a
		mov ebx, b
		and eax, ebx
		mov rez, eax
	}

	cout << "a= " << a << " b = " << b << " rez = " << rez;

	cout << endl;
	int x;
	cin >> x;
	return 0;
}

