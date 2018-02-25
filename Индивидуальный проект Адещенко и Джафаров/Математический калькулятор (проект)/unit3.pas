unit Unit3;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm3 }

  TForm3 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Image1: TImage;
    Memo1: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Memo1Change(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form3: TForm3;

implementation
uses Unit2 , Unit1 , Unit4;

{$R *.lfm}

{ TForm3 }

procedure TForm3.Memo1Change(Sender: TObject);
begin
end;

procedure TForm3.FormCreate(Sender: TObject);
begin

end;

procedure TForm3.Button1Click(Sender: TObject);
begin
Form1.Show();
Form3.Hide();
end;

procedure TForm3.Button2Click(Sender: TObject);
begin
Form2.Show();
Form3.Hide();
end;

procedure TForm3.Button3Click(Sender: TObject);
begin
Form4.Show();
Form3.Hide();
end;

end.

