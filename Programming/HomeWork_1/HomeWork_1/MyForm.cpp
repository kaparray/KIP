#include "MyForm.h"
#include <math.h>

using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
void Main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	HomeWork1::MyForm form;
	Application::Run(%form);
}

float castomMax(float num1, float num2) {
	if (num1 > num2) return num1;
	else  return  num2;
}

void HomeWork1::MyForm::setValue()
{
	x = Convert::ToSingle(textBox1->Text);
	y = Convert::ToSingle(textBox2->Text);
	c = Convert::ToSingle(textBox3->Text);
	d = Convert::ToSingle(textBox4->Text);
}

float HomeWork1::MyForm::getValue(float x, float y, float c, float d) {
	float xy = x * y;
	float cx = c * x;
	float dy = d * y;




	if (xy > 3) {
		return x * x * x + pow(log10(xy), d*c);
	}
	else if (2 <= x && x <= 3) {
		if (x < y && x < x < castomMax(cx, dy)) {
			return 3 * x;
		}
		else if (y < x && y < castomMax(cx, dy)) {
			return 3 * y;
		}
		else if (castomMax(cx, dy) < x && castomMax(cx, dy) < y) {
			return 3 * castomMax(cx, dy);
		}
	}
	else if (xy < 0) {
		return pow(2, c*d) - x;
	}
}

