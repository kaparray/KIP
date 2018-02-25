unit Unit11;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm11 }

  TForm11 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Image1: TImage;
    Memo1: TMemo;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Image1Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form11: TForm11;

implementation
 uses Unit1, Unit2, Unit3,Unit6,unit4;
{$R *.lfm}

 { TForm11 }

  procedure TForm11.Button1Click(Sender: TObject);
 begin
   Form1.Show();
   Form11.Hide();
 end;

procedure TForm11.Button2Click(Sender: TObject);
begin
  Form2.Show();
  Form11.Hide();
end;

procedure TForm11.Button3Click(Sender: TObject);
begin
  Form4.Show();
  Form11.Hide();
end;

procedure TForm11.Button4Click(Sender: TObject);
begin
  Form6.Show();
  Form11.Hide();
end;

procedure TForm11.FormCreate(Sender: TObject);
begin

end;

procedure TForm11.Image1Click(Sender: TObject);
begin

end;

{ TForm11 }

end.

