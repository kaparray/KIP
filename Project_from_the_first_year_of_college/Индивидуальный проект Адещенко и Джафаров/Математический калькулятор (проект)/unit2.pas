unit Unit2;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm2 }

  TForm2 = class(TForm)
    Button1: TButton;
    Button3: TButton;
    Button4: TButton;
    Image1: TImage;
    Image2: TImage;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image2Click(Sender: TObject);

  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form2: TForm2;

implementation
uses Unit4 , Unit3 , Unit1 , Unit7,Unit9;

{$R *.lfm}

{ TForm2 }

procedure TForm2.FormCreate(Sender: TObject);
begin

end;

procedure TForm2.Image2Click(Sender: TObject);
begin

end;

procedure TForm2.Button1Click(Sender: TObject);
begin
Form1.Show();
Form2.Hide();
end;

procedure TForm2.Button2Click(Sender: TObject);
begin
Form7.Show();
Form2.Hide();
end;

procedure TForm2.Button3Click(Sender: TObject);
begin
Form3.Show();
Form2.Hide();
end;

procedure TForm2.Button4Click(Sender: TObject);
begin
Form9.Show();
Form2.Hide();
end;

end.

