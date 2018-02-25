unit Unit12;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls, Math;

type

  { TForm12 }

  TForm12 = class(TForm)
    Button1: TButton;
    Button10: TButton;
    Button11: TButton;
    Button12: TButton;
    Button13: TButton;
    Button14: TButton;
    Button15: TButton;
    Button16: TButton;
    Button17: TButton;
    Button18: TButton;
    Button19: TButton;
    Button2: TButton;
    Button20: TButton;
    Button21: TButton;
    Button22: TButton;
    Button23: TButton;
    Button24: TButton;
    Button25: TButton;
    Button26: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Button6: TButton;
    Button7: TButton;
    Button8: TButton;
    Button9: TButton;
    Edit1: TEdit;
    Image1: TImage;
    procedure Button10Click(Sender: TObject);
    procedure Button11Click(Sender: TObject);
    procedure Button12Click(Sender: TObject);
    procedure Button13Click(Sender: TObject);
    procedure Button14Click(Sender: TObject);
    procedure Button15Click(Sender: TObject);
    procedure Button16Click(Sender: TObject);
    procedure Button17Click(Sender: TObject);
    procedure Button18Click(Sender: TObject);
    procedure Button19Click(Sender: TObject);
    procedure Button1Click(Sender: TObject);
    procedure Button20Click(Sender: TObject);
    procedure Button21Click(Sender: TObject);
    procedure Button22Click(Sender: TObject);
    procedure Button23Click(Sender: TObject);
    procedure Button24Click(Sender: TObject);
    procedure Button25Click(Sender: TObject);
    procedure Button26Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure Button6Click(Sender: TObject);
    procedure Button7Click(Sender: TObject);
    procedure Button8Click(Sender: TObject);
    procedure Button9Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form12: TForm12;
  kod: char;
  x,y,z:real;

implementation
uses unit1;

{$R *.lfm}

{ TForm12 }

procedure TForm12.FormCreate(Sender: TObject);
begin

end;

procedure TForm12.Button8Click(Sender: TObject);
begin
Edit1.Text:=Edit1.Text+'1';
end;

procedure TForm12.Button9Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'2';
end;

procedure TForm12.Button21Click(Sender: TObject);
begin
Form1.Show();
Form12.Hide();
end;

procedure TForm12.Button22Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'8';
end;

procedure TForm12.Button23Click(Sender: TObject);
Var k, y1:integer;
p:single;
begin
if Edit1.Text<>' ' then
   Begin
   y:=strtofloat(Edit1.Text);
   case kod of
        '+':z:=x+y;
        '-':z:=x-y;
        '*':z:=x*y;
        '/':Begin
            if y<>0 then
               z:=x/y
            Else
            ShowMessage('Нельзя делить на ноль');
            end;
        '%':z:=(x/100)*y;
        '^':Begin
            p:=strtofloat(Edit1.Text);
            if p>=1 then
               Begin
               y1:=strtoint(Edit1.Text);
               Edit1.Clear;
               z:=1;
               For k:=1 to y1 do
                   z:=z*x;
               end
               Else
               ShowMessage('Вы должны ввести натуральное число');
            end;
   end;
   end;

Edit1.Text:=floattostr(z);

end;

procedure TForm12.Button24Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'7';
end;

procedure TForm12.Button25Click(Sender: TObject);
begin
if Edit1.Text<>' ' then
   x:=strtofloat(Edit1.Text);
   kod:='^';
   Edit1.Clear;
end;

procedure TForm12.Button26Click(Sender: TObject);
begin
if Edit1.Text<>' ' then
   x:=strtofloat(Edit1.Text);
   kod:='%';
   Edit1.Clear;
end;

procedure TForm12.Button2Click(Sender: TObject);
begin
  x:=strtofloat(Edit1.Text);
  Edit1.Clear;
  z:=cos(x);
  Edit1.Text:=floattostr(z);
end;

procedure TForm12.Button3Click(Sender: TObject);
begin
  x:=strtofloat(Edit1.Text);
  Edit1.Clear;
  z:=sin(x);
  Edit1.Text:=floattostr(z);
end;

procedure TForm12.Button4Click(Sender: TObject);
begin
  x:=strtofloat(Edit1.Text);
  Edit1.Clear;
  z:=tan(x);
  Edit1.Text:=floattostr(z);
end;

procedure TForm12.Button5Click(Sender: TObject);
begin
  Edit1.Clear;
end;

procedure TForm12.Button6Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+',';
end;

procedure TForm12.Button7Click(Sender: TObject);
begin
  x:=strtofloat(Edit1.Text);
  Edit1.Clear;
  z:=sqrt(x);
  Edit1.Text:=floattostr(z);
end;

procedure TForm12.Button10Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'3';
end;

procedure TForm12.Button11Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'4';
end;

procedure TForm12.Button12Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'5';
end;

procedure TForm12.Button13Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'6';
end;

procedure TForm12.Button14Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'0';
end;

procedure TForm12.Button15Click(Sender: TObject);
begin
  Edit1.Text:=Edit1.Text+'9';
end;

procedure TForm12.Button16Click(Sender: TObject);
begin
if Edit1.Text<>' ' then
   x:=strtofloat(Edit1.Text);
   kod:='*';
   Edit1.Clear;
end;

procedure TForm12.Button17Click(Sender: TObject);
begin
if Edit1.Text<>' ' then
   x:=strtofloat(Edit1.Text);
   kod:='/';
   Edit1.Clear;
end;

procedure TForm12.Button18Click(Sender: TObject);
begin
if Edit1.Text<>' ' then
   x:=strtofloat(Edit1.Text);
   kod:='-';
   Edit1.Clear;
end;

procedure TForm12.Button19Click(Sender: TObject);
begin
if Edit1.Text<>' ' then
   x:=strtofloat(Edit1.Text);
   kod:='+';
   Edit1.Clear;
end;

procedure TForm12.Button1Click(Sender: TObject);
Var str:string;
begin
str:=Edit1.Text;
if str<>' ' then
   delete(str, length(str),1);
   Edit1.Text:=str;
end;

procedure TForm12.Button20Click(Sender: TObject);
begin
  x:=strtofloat(Edit1.Text);
  Edit1.Clear;
  z:=cotan(x);
  Edit1.Text:=floattostr(z);
end;

end.

