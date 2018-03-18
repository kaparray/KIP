#pragma once

namespace PartyHomeWork {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// —водка дл€ MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	private: int len = 0; // Lenght array
	private: float *array = new float[len];
	private: float negative_num = 0;
	private: float positive_num = 0;
	private: float arifm = 0;
	private: float negative_counter = 0;
	private: float positive_counter = 0;
	private: System::Windows::Forms::TextBox^  textBox1;
	private: System::Windows::Forms::Label^  label1;
	private: System::Windows::Forms::Label^  label2;
	private: System::Windows::Forms::Label^  label3;
	private: System::Windows::Forms::Label^  label4;
	private: System::Windows::Forms::Label^  label5;





	protected:

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(38, 314);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(171, 90);
			this->button1->TabIndex = 0;
			this->button1->Text = L"Get Result";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm::button1_Click);
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(174, 50);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 31);
			this->textBox1->TabIndex = 1;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(307, 50);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(436, 25);
			this->label1->TabIndex = 2;
			this->label1->Text = L"In this position visible array after click button";
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(23, 56);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(145, 25);
			this->label2->TabIndex = 4;
			this->label2->Text = L"Lenght array: ";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Location = System::Drawing::Point(33, 127);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(70, 25);
			this->label3->TabIndex = 5;
			this->label3->Text = L"Positive number = ";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Location = System::Drawing::Point(33, 180);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(70, 25);
			this->label4->TabIndex = 6;
			this->label4->Text = L"Negative number = ";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Location = System::Drawing::Point(33, 246);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(70, 25);
			this->label5->TabIndex = 7;
			this->label5->Text = L"Answer = ";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(900, 609);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	
	void PartyHomeWork::MyForm::setValue();
	void PartyHomeWork::MyForm::setArray(int len, float *array);
	void PartyHomeWork::MyForm::getArray();
	float  PartyHomeWork::MyForm::getAnswer(float pn, float pc, float nn, float nc);


	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		negative_counter = 0;
		negative_num = 0;
		positive_counter = 0;
		positive_num = 0;

		setValue();
		setArray(len, array);
		getArray();
		/*((MessageBox::Show(
			"Are you sure that you would like to close the form?",
			"Form Closing", MessageBoxButtons::OK,
			MessageBoxIcon::Question)));*/
	
		label3->Text = "Positive number = " + positive_counter;
		label4->Text = "Negative number = " + negative_counter;
		label5->Text = "Answer = " + Convert::ToSingle(getAnswer(positive_num, positive_counter, negative_num, negative_counter));
	}
	

};
}
