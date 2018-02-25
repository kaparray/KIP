unit Unit14;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ExtCtrls,Math,
  StdCtrls, Menus, ColorBox ;

type

  { TForm14 }

  TForm14 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    ComboBox1: TComboBox;
    Edit1: TEdit;
    Edit2: TEdit;
    Edit3: TEdit;
    Edit4: TEdit;
    Image1: TImage;
    Image2: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Label3: TLabel;
    Label4: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure ColorBox1Change(Sender: TObject);
    procedure ComboBox1Change(Sender: TObject);
    procedure Edit1Change(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image2Click(Sender: TObject);
    procedure MenuItem1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form14: TForm14;

implementation
uses Unit13,Unit1;
{$R *.lfm}

{ TForm14 }

procedure TForm14.Button1Click(Sender: TObject);
var
  zero,katet1,katet2,gip,gip_v2,gip_end,_katet1_,_gip_,_katet2_,_katet_v2_,_katet_end,gip_test,_katet2_v3_ :single;
Begin
  zero:=0;
  _katet1_:=0;
  _gip_:=0;
  katet1:=0;
  katet2:=0;




  if (ComboBox1.ItemIndex=0) then  //Нахождение гипотенузы
     begin

     katet1:=strtofloat(Edit1.Text);
     katet2:=strtofloat(Edit2.Text);
     MessageDlg('Математический калькулятор', 'Вы уверенны в правельности введённого?',mtConfirmation, [mbOk,mbCancel] , 0);
      Begin
     if ((katet1=zero) or (katet2=zero)) or ((katet1=zero) and (katet2=zero)) then

        MessageDlg('Введите требуемые числа',mtWarning,[mbOk,mbCancel],0)


     else

     BEGIN
       gip:=sqrt(power(katet1,2)+power(katet2,2));
       gip_end:=int(gip);//Это целое число без корня
       Edit3.Text:=floattostr(gip);
       Edit4.Text:=floattostr(gip_end);


     END;
     End
     end

  else if  (ComboBox1.ItemIndex=1) then //Нахождение катета
     begin


     _katet1_:=strtofloat(Edit1.Text);
     _gip_:=strtofloat(Edit3.Text);
     MessageDlg('Математический калькулятор', 'Вы уверенны в правельности введённого?',mtConfirmation, [mbOk,mbCancel] , 0);

     if ((_katet1_=zero) or (_gip_=zero)) or ((_katet1_=zero) and (_gip_=zero)) then

        MessageDlg('Введите требуемые числа',mtWarning,[mbOk,mbCancel],0)


     else

     BEGIN
        _katet2_:=sqrt(power(_gip_,2)-power(_katet1_,2));
        _katet_end:=int(_katet2_);
        Edit2.Text:=floattostr(_katet2_);
        Edit4.Text:=floattostr(_katet_end);

     END
     end
  else if (ComboBox1.ItemIndex=-1) Then
      MessageDlg('Необходимо выбрать что мы находим!',mtWarning,[mbOk,mbCancel],0)

  else
      MessageDlg('Что-то не так',mtWarning,[mbOk,mbCancel],0);







end;

procedure TForm14.Button2Click(Sender: TObject);
begin
 Form1.Show();
 Form14.Hide();
end;

procedure TForm14.ColorBox1Change(Sender: TObject);
begin

end;

procedure TForm14.ComboBox1Change(Sender: TObject);
begin

end;

procedure TForm14.Edit1Change(Sender: TObject);
begin

end;

procedure TForm14.FormCreate(Sender: TObject);
begin

end;

procedure TForm14.Image2Click(Sender: TObject);
begin

end;

procedure TForm14.MenuItem1Click(Sender: TObject);
begin

end;



end.

