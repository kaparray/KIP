unit Unit8;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls;

type

  { TForm8 }

  TForm8 = class(TForm)
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);

  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form8: TForm8;

implementation
uses unit1, Unit2, Unit3,Unit4,Unit11,Unit7;
{$R *.lfm}

{ TForm8 }

procedure TForm8.Button1Click(Sender: TObject);
begin
Form1.Show();
Form8.Hide();
end;

procedure TForm8.Button2Click(Sender: TObject);
begin
Form2.Show();
Form8.Hide();
end;

procedure TForm8.Button3Click(Sender: TObject);
begin
Form7.Show();
Form8.Hide();
end;

procedure TForm8.FormCreate(Sender: TObject);
begin

end;



end.

