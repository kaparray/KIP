unit Unit9;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm8 }

  { TForm9 }

  TForm9 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Image1: TImage;
    Memo1: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image1Click(Sender: TObject);
    procedure Memo1Change(Sender: TObject);

  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form9: TForm9;

implementation
uses Unit1, Unit2, Unit3,Unit4,Unit11,Unit7 , Unit10;
{$R *.lfm}

{ TForm9 }



procedure TForm9.Button1Click(Sender: TObject);
begin
Form1.Show();
Form9.Hide();
end;

procedure TForm9.Button2Click(Sender: TObject);
begin
Form2.Show();
Form9.Hide();
end;

procedure TForm9.Button3Click(Sender: TObject);
begin
Form10.Show();
Form9.Hide();
end;

procedure TForm9.FormCreate(Sender: TObject);
begin

end;

procedure TForm9.Image1Click(Sender: TObject);
begin

end;

procedure TForm9.Memo1Change(Sender: TObject);
begin

end;

end.

