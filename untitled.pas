Создание Dll
Dll - динамическая библиотека

Dynamic Link Libraty  Lazarus

1)Файл -> Создать -> Библилтека 

2)Librarty Project1;

.
.

begin
end.

3)Сохранить всё
4)Запуск -> компилировать. Будет созданна sumdll.dlll

Functoin Summ(x,y:Integer): Integer;
stdClall; // Если в lazarus то ненадо

begin
result := x+y;
end;
exports Summ; control+F9 // for compilation


procedure TForm1Button1Click
var res : Integer;
begin
rez := summ(40,50);
MessageDlg ... + IntToStr(rez)  ... ; 
end;


В implementation подключить: implementation function summ(x,y:Integer):Integer;
external 'summ.dll.dll' name summ; // Подключить в программе

// end 


procddure summ(x,y:integer):integer;
var result : Integer;
stdcall;
begin
result := x+y;
end;
export summ;

..
..

begin
end.

В implementation :
	procedure summ(x,y:Integer);
	var x:Integer
	external 'summ.dll' name summ;



procedure TForm1Button1Click
var z : Integer;
begin
summ(50,100,z);
MessageDlg ... + IntToStr(z)  ... ; 
end;


//   ВИДИМОСТЬ  stringgread

1) В uses ... , Grids

описание видимости массива

2) procedure vvod(var a:mas n1:integer;stringGrid1:TStringGrid);
	stdcall;


3) LCLBase (Проект->Инспектор проекта-> Добаваить) //Нужно сделать

4) Не найдено Interfaces

5) Не найден LCL (Проект->Инспектор проекта-> Добаваить)

6) Не обращаться к form1 тк это в Dll



Дз:  Создание dll библиотек

////////////////////////
//// Создание в C++ ////
////////////////////////



