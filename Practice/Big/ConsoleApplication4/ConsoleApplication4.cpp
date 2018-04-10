// ConsoleApplication4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"


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



boolean is_balance(char *str, int &position) {
	boolean answ = false;


	if ((str[0] == '+' &&  !isdigit(str[1])) || str[0] == '/' || str[0] == '*' || str[0] == '^' ) { answ = false; }
	
	for (int i = 0; i < MAX; i++)
	{
		if (str[i] == '-') {
			if (i == 0) {

			}else if (str[i] == '-' && str[i - 1] != '(') {
				answ = false;
				position = i;
			}
		}
		
		if (str[i] == '/' || str[i] == '-' || str[i] == '*' || str[i] == '^') {

			
			
				if (str[i - 1] == '-' || str[i + 1] == '-'  || str[i - 1] == '+' || str[i + 1] == '+' || str[i - 1] == '/' || str[i + 1] == '/' || str[i - 1] == '*' || str[i + 1] == '*' || str[i - 1] == '^' || str[i + 1] == '^' || str[i+1] == NULL) {
					answ = false;
					position = i;
				}
				
				else {
					answ = true;
				}
		}
	}
	
	return answ;
}


using namespace std;
HANDLE console = GetStdHandle(STD_OUTPUT_HANDLE);
COORD CursorPosition;
void gotoXY(int, int);
int main()
{
	int position =0;

	system("color 07");
	system("title ");
	SetConsoleOutputCP(1251);
	SetConsoleCP(1251);
	int menu_item = 0, run, x = 7;
	bool running = true;
	bool running2 = true;
	char ch;
	int vib = 0;
	char str[MAX];
	std::string s[MAX];
	gotoXY(2, 5); cout << "Главное меню ";
	gotoXY(2, 7); cout << ">>";
	while (running)
	{
		gotoXY(4, 7);
		cout << "1) Ввод текста с клавиатуры";
		gotoXY(4, 8);
		cout << "2) Выход";
		system("pause>nul");
		if (GetAsyncKeyState(VK_DOWN) && x != 8)
		{
			gotoXY(2, x);
			cout << " ";
			gotoXY(3, x);
			cout << " ";
			x++;
			gotoXY(2, x); cout << ">>";
			menu_item++; continue;
		}
		if (GetAsyncKeyState(VK_UP) && x != 7)
		{
			gotoXY(2, x);
			cout << " ";
			gotoXY(3, x);
			cout << " ";
			x--;
			gotoXY(2, x);
			cout << ">>";
			menu_item--;
			continue;
		}
		if (GetAsyncKeyState(VK_RETURN))
		{
			switch (menu_item)
			{
			case 0:
			{
				while (running2)
				{
					gotoXY(4, 7);
					cout << "1) Ввод текста с клавиатуры";
					gotoXY(4, 8);
					cout << "2) Ввод текста из файла";
					gotoXY(4, 9);
					cout << "3) Выход";
					system("pause>nul");
					if (GetAsyncKeyState(VK_DOWN) && x != 9)
					{
						gotoXY(2, x);
						cout << " ";
						gotoXY(3, x);
						cout << " ";
						x++;
						gotoXY(2, x); cout << ">>";
						menu_item++; continue;
					}
					if (GetAsyncKeyState(VK_UP) && x != 7)
					{
						gotoXY(2, x);
						cout << " ";
						gotoXY(3, x);
						cout << " ";
						x--;
						gotoXY(2, x);
						cout << ">>";
						menu_item--;
						continue;
					}
					if (GetAsyncKeyState(VK_RETURN))
					{
						switch (menu_item)
						{
						case 0:
						{
							gotoXY(2, 16);
							cout << "Введите текст: ";
							cin >> str;

							cout << "Ваш текст: ";
							cout << str;
							puts(is_balance(str, position) ? " Да,Правильно!" : " Нет,ошибка");
							cout << "Ошибка на позиции = " << position + 1;

							break;
						}
						case 1:
							break;
						case 2: 
							gotoXY(4, 16);
							cout << "Вход";
							running = false;
							running2 = false;
							exit(1);
						break;
						}
					}
				}
			}
			case 1:
			{
			gotoXY(4, 16);
			cout << "Вход";
			running = false;
			exit(1);
			}
			break;

			
			}
		}
	}
	gotoXY(4, 21);
	return 0;
}

void gotoXY(int x, int y)
{
	CursorPosition.X = x;
	CursorPosition.Y = y;
	SetConsoleCursorPosition(console, CursorPosition);
}

