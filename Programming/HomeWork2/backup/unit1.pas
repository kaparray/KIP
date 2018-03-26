unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, Grids,
  StdCtrls;

Type mas = array of Real;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Label1: TLabel;
    SG1: TStringGrid;
    SG2: TStringGrid;
    procedure Label1Click(Sender: TObject);
    procedure ShowInGrid1(arr:mas);
    procedure ShowInGrid2(arr:mas);
    procedure Button1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.lfm}

{ TForm1 }



function GenerateArray(length:Integer):mas;
var arr:mas;
    i:integer;
begin
  SetLength(arr, length);
  randomize;
  for i:= Low(arr) to High(arr) do
    arr[i]:=random(100) - 50;
  result:=arr;
end;

procedure TForm1.ShowInGrid1(arr:mas);
var i:Integer;
begin
  SG1.ColCount:=Length(arr);
  for i := Low(arr) to High(arr) do
  begin
    SG1.Cells[i, 0]:= intToStr(i);
    SG1.Cells[i, 1]:= floatToStr(arr[i]);
  end;
end;

procedure TForm1.Label1Click(Sender: TObject);
begin

end;

procedure TForm1.ShowInGrid2(arr:mas);
var i:Integer;
begin
  SG2.ColCount:=Length(arr);
  for i := Low(arr) to High(arr) do
  begin
    SG2.Cells[i, 0]:= intToStr(i);
    SG2.Cells[i, 1]:= floatToStr(arr[i]);
  end;
end;

function pos(arr:mas):Integer;
var i: Integer;
    ind: integer;
begin
  ind := 0;
  for i := Low(arr) to High(arr) do
  begin
    if(arr[i] > 0) then
      ind := ind + 1;
  end;
  result:=ind;
end;

procedure NewArr(a:mas; min:Integer; var b:mas);
var i:Integer;
begin
  SetLength(b, 0);
  for i:= Low(a) to High(a) do
  begin
         if(a[i] > min) then
       begin
         Setlength(b, length(b) + 1);
         b[High(b)] := a[i];
       end;

  end;
end;

procedure TForm1.Button1Click(Sender: TObject);
var arr, rez_arr:mas;
    len, len_array:integer;
begin
  Val(InputBox('Введите количество элементов в массиве', 'Кол-во: ', ''), len);
  arr := GenerateArray(len);
  ShowInGrid1(arr);
  len_array := pos(arr);
  NewArr(arr, len_array, rez_arr);
  ShowInGrid2(rez_arr);
end;

end.


