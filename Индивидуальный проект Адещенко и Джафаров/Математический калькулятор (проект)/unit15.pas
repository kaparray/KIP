unit Unit15;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls, Math;

type

  { TForm15 }

  TForm15 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Edit5: TEdit;
    Image1: TImage;
    Image2: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    Label5: TLabel;
    Label6: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form15: TForm15;

implementation
uses Unit1, Unit13;

{$R *.lfm}

{ TForm15 }

procedure TForm15.Button1Click(Sender: TObject);
Var a,b,c,k,v,d,x1,x2: single;
begin
if (Edit1.Text='0') and ((Edit2.Text='') or (Edit2.Text='0')) and ((Edit3.Text='') or (Edit3.Text='0')) then
   Begin
   showmessage('Вы не ввели данные');
   Edit1.Clear;
   Edit2.Clear;
   Edit3.Clear;
   abort;
   end;
if ((Edit2.Text='') or (Edit2.Text='0')) and ((Edit3.Text='') or (Edit3.Text='0')) then
   Begin
   showmessage('Вы не ввели обязательное количество данных');
   Edit1.Clear;
   Edit2.Clear;
   Edit3.Clear;
   abort;
   end;
if Edit1.Text<>''  then
   a:=strtofloat(Edit1.Text)
   Else
   Begin
   a:=1;
   end;
if (Edit1.Text='0') then
   showmessage(' Переменная "a" не может быть равна 0');
if (Edit2.Text='') or (Edit2.Text='0')  then
   Begin
   c:=strtofloat(Edit3.Text);
   if c<0 then
      c:=abs(c)
      Else
      showmessage(' У квадратного уравнения нету корней');
   if Edit1.Text='' then
      Begin
      x1:=sqrt(c);
      x2:=(-1)*(sqrt(c));
      Edit4.Text:=floattostr(x1);
      Edit5.Text:=floattostr(x2);
      end
      Else
      Begin
      v:=(c/a);
      if v<=0 then
         showmessage('У квадратного уравнения нету корней ')
         Else
         Begin
         x1:=sqrt(v);
         x2:=(-1)*sqrt(v);
         Edit4.Text:=floattostr(x1);
         Edit5.Text:=floattostr(x2);
         end
      end;
   end
   Else
   b:=strtofloat(Edit2.Text);
if (Edit3.Text='') or (Edit3.Text='0') then
   Begin
   b:=strtofloat(Edit2.Text);
   if a=1 then
      Begin
      x1:=0;
      if b<0 then
         x2:=abs(b)
         Else
         x2:=(-1)*b;
      Edit4.Text:=floattostr(x1);
      Edit5.Text:=floattostr(x2);
      end
      Else
      Begin
      if b>0 then
         Begin
         b:=abs(b);
         end
         Else
         Begin
         b:=(-1)*b;
         end;
      v:=(b/a);
      x1:=0;
      x2:=v;
      Edit4.Text:=floattostr(x1);
      Edit5.Text:=floattostr(x2);
      end;
   end
   Else
   c:=strtofloat(Edit3.Text);
if (a<>0) and (b<>0) and (c<>0) then
   Begin
   k:=(b*b)-4*a*c;
   if k<=0 then
      Begin
      showmessage('У квадратного уравнения нет корней');
      Edit1.Clear;
      Edit2.Clear;
      Edit3.Clear;
      end
      Else
      Begin
      x1:=0;
      x2:=0;
      d:=sqrt(k);
      x1:=((b*(-1))+d)/(2*a);
      x2:=((b*(-1))-d)/(2*a);
      Edit1.Clear;
      Edit2.Clear;
      Edit3.Clear;
      Edit4.Text:=floattostr(x1);
      Edit5.Text:=floattostr(x2);
      end;
   end;
end;

procedure TForm15.Button2Click(Sender: TObject);
begin
Form1.Show;
Form15.Hide;
end;

procedure TForm15.Button3Click(Sender: TObject);
begin
Form13.Show;
Form15.Hide;
end;

end.

