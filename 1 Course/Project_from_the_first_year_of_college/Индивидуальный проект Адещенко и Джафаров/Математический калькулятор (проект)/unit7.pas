unit Unit7;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm7 }

  TForm7 = class(TForm)
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form7: TForm7;

implementation
uses Unit1,Unit2,Unit8;
{$R *.lfm}

{ TForm7 }

procedure TForm7.Button1Click(Sender: TObject);
begin
Form1.Show();
Form7.Hide();
end;

procedure TForm7.Button2Click(Sender: TObject);
begin
Form2.Show();
Form7.Hide();
end;

procedure TForm7.Button3Click(Sender: TObject);
begin
Form8.Show();
Form7.Hide();
end;

end.

