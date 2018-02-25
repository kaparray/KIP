unit Unit16;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, ExtCtrls,
  StdCtrls, ComCtrls;

type

  { TForm16 }

  TForm16 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Image1: TImage;
    Image2: TImage;
    Label1: TLabel;
    Label2: TLabel;
    Timer1: TTimer;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure Label1Click(Sender: TObject);
    procedure Label2Click(Sender: TObject);
    procedure Timer1Timer(Sender: TObject);

  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form16: TForm16;

implementation
uses unit1,Unit5;

{$R *.lfm}

{ TForm16 }

procedure TForm16.Button1Click(Sender: TObject);
begin
  Form5.Show();
  Form16.Hide();
  Timer1.enabled:=True;


end;

procedure TForm16.Button2Click(Sender: TObject);
begin
  Form16.Label2.Left:=24

end;

procedure TForm16.FormCreate(Sender: TObject);
begin

end;

procedure TForm16.Label1Click(Sender: TObject);
begin

end;

procedure TForm16.Label2Click(Sender: TObject);
begin

end;

procedure TForm16.Timer1Timer(Sender: TObject);
begin

  With Form5.ProgressBar1 Do
begin

  Position:=Position+10;
  Form5.Panel1.Caption:= 'Загрузка: ' +IntToStr(Position)+ '%';
  If Position = Max Then
  begin
    Form1.Show();
    Form5.Hide();
    Position:=-2147483648;
    Form5.Panel1.Caption:=IntToStr(0);
    Timer1.enabled:=False;
    end;
  end;
end;



end.

