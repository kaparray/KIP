#define _CRT_SECURE_NO_WARNINGS 
#define MAX 500 

#include <stdio.h> 
#include <Windows.h> 
#include <ctime> 
#include <cstdlib> 
#include <string.h > 
#include <string> 
#include <iostream> 
#include <conio.h> 
#include <windows.h> 
#include <stack> 
#include <fstream> 

using namespace std;
HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
COORD CursorPosition;
void gotoXY(int, int);


void arrayInput() {
	int **a = new int*[2];

	for (int i = 0; i < 2; i++) {
		a[i] = new int[10];
	}


	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 10; j++) {
			cout << "Введите a[" << i << "][" << j << "] = ";
			cin >> a[i][j];
		}
	}

	cout << endl;

	for (int i = 0; i < 10; i++) {
		int y = a[0][i] + a[1][i];
		if (y > 0) {
			cout << "Сумма больше 0 => a[1][" << i << "] *  a[2][" << i << "] =" << a[0][i] * a[1][i] << endl;
		}
		else {
			break;
			cout << "Остановка цикла :( " << endl;
		}
	}
}

void randArray() {
	int **a = new int*[2];

	for (int i = 0; i < 2; i++) {
		a[i] = new int[10];
	}


	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 10; j++) {
			a[i][j] = rand() % 10 - 2;
			cout <<  a[i][j] << " ";
		}
		puts("");
	}

	cout << endl;

	for (int i = 0; i < 10; i++) {
		int y = a[0][i] * a[1][i];
		if (y < 0) {
			cout << "Остановка цикла :( " << endl;			break;
		}
		else {
			
			cout << "Сумма больше 0 => a[1][" << i << "] *  a[2][" << i << "] =" << y << endl;
		}
	}
}


void writeArray() {
	ifstream reader("input.txt");
	int **a = new int*[2];

	for (int i = 0; i < 2; i++) {
		a[i] = new int[10];
	}


	for (int i = 0; i < 2; i++) {
		for (int j = 0; j < 10; j++) {
			reader >> a[i][j];
		}
	}


	cout << endl;

	for (int i = 0; i < 10; i++) {
		int y = a[0][i] * a[1][i];
		if (y > 0) {
			cout << "Сумма больше 0 => a[1][" << i << "] *  a[2][" << i << "] =" << a[0][i] * a[1][i] << endl;
		}
		else {
			break;
			cout << "Остановка цикла :( " << endl;
		}
	}
}


int main()
{
	setlocale(LC_ALL, "ru-ru");
	int count = 0;

	int menu_item = 0, run, x = 7;
	bool running = true;
	gotoXY(18, 5);
	cout << "Главное меню:";
	gotoXY(18, 7);
	cout << "->";
	while (running)
	{
		gotoXY(20, 7);
		cout << "1) Ввод с клавиатуры";
		gotoXY(20, 8);
		cout << "2) Ввод рвндомно";
		gotoXY(20, 9);
		cout << "3) Ввод из файла";
		gotoXY(20, 10);
		cout << "4) Выход из программы";
		

		system("pause>nul");
		if (GetAsyncKeyState(VK_DOWN) && x != 11)
		{
			gotoXY(18, x);
			cout << "  ";
			x++; gotoXY(18, x);
			cout << "->";
			menu_item++;
			continue;
		}
		if (GetAsyncKeyState(VK_UP) && x != 7)
		{
			gotoXY(18, x);
			cout << "  ";
			x--; gotoXY(18, x);
			cout << "->";
			menu_item--;
			continue;
		}
		if (GetAsyncKeyState(VK_RETURN)) {
			switch (menu_item)
			{
			case 0:
			{
				if (count != 0) {
					for (int i = 16; i < 60; i++) {
						std::cout << "                                                       ";
						gotoXY(0, i);
					}
				}

				gotoXY(0, 16);
				cout << "Вы выбрали : Ввод с клавиатуры" << endl;
				arrayInput();
				count++;
				break;
			} case 1:
			{ gotoXY(20, 16);
			
		
			if (count != 0) {
				for (int i = 16; i < 60; i++) {
					std::cout << "                                                       ";
					gotoXY(0, i);
				}
			}

			gotoXY(0, 16);
			cout << "Вы выбрали : Ввод рандомно" << endl;
			randArray();
			count++;
			break;
		
			
			
			break;
			} case 2:
			{
				if (count != 0) {
					for (int i = 16; i < 60; i++) {
						std::cout << "                                                       ";
						gotoXY(0, i);
					}
				}

				gotoXY(0, 16);

			writeArray();
			count++;


			break;
			} case 3:
			{ gotoXY(20, 16);
			cout << "The program has now terminated!!";
			running = false;
			break;
			} case 4:
			{ gotoXY(20, 16);
			cout << "The program has now terminated!!";
			running = false;
			}
			}
		}
	}
	gotoXY(20, 21);
	return 0;
}
void gotoXY(int x, int y)
{
	CursorPosition.X = x;
	CursorPosition.Y = y;
	SetConsoleCursorPosition(console, CursorPosition);
}
