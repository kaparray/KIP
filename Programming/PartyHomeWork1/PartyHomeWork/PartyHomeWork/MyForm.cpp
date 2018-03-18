#include "MyForm.h"
#include <math.h>
#include <time.h>
#include <stdlib.h>

using namespace System;
using namespace System::Windows::Forms;
[STAThreadAttribute]
void Main(array<String^>^ args) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	PartyHomeWork::MyForm form;
	Application::Run(%form);
}

void PartyHomeWork::MyForm::setValue()
{
	len = Convert::ToSingle(textBox1->Text);
}

void  PartyHomeWork::MyForm::setArray(int len, float *array) {

	srand(time(NULL));
	//float *array = new float[10];
	for (int i = 0; i < len; i++) {
		array[i] = rand() % 100 - 50;
		if (array[i] >= 0) {
			positive_num += array[i];
			positive_counter++;
		}else {
			negative_num += array[i];
			negative_counter++;
		}
	}
}

void PartyHomeWork::MyForm::getArray(){
	String^ arrayString;
	for (int i = 0; i < len; i++) {
		arrayString += " Array[" + i + "] = " + array[i] + "\n";
	}
	label1->Text = arrayString;
}

float  PartyHomeWork::MyForm::getAnswer(float pn, float pc, float nn, float nc) {
	float num1 = (positive_num / positive_counter);
	float num2 = (negative_num / negative_counter);
	return num1/num2;
}