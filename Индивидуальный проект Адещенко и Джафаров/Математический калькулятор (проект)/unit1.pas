unit Unit1;

{$mode objfpc}{$H+}

interface

uses
  Classes, SysUtils, FileUtil, Forms, Controls, Graphics, Dialogs, StdCtrls,
  ExtCtrls;

type

  { TForm1 }

  TForm1 = class(TForm)
    Button1: TButton;
    Button2: TButton;
    Button3: TButton;
    Button4: TButton;
    Button5: TButton;
    Image1: TImage;
    Label1: TLabel;
    procedure Button1Click(Sender: TObject);
    procedure Button2Click(Sender: TObject);
    procedure Button3Click(Sender: TObject);
    procedure Button4Click(Sender: TObject);
    procedure Button5Click(Sender: TObject);
    procedure FormCreate(Sender: TObject);



  private
    { private declarations }
  public
    { public declarations }
  end;

var
  Form1: TForm1;

implementation
uses Unit12, Unit16,Unit15,Unit14,unit2;

{$R *.lfm}

{ TForm1 }


procedure TForm1.Button1Click(Sender: TObject);
begin
Form2.Show();
Form1.Hide();

end;

procedure TForm1.Button2Click(Sender: TObject);
begin
Form12.Show;
Form1.Hide;
end;

procedure TForm1.Button3Click(Sender: TObject);
begin

Form15.Show();
Form1.Hide();
end;

procedure TForm1.Button4Click(Sender: TObject);
begin
  Form16.Show();
  Form1.Hide();
end;

procedure TForm1.Button5Click(Sender: TObject);
begin
  Form14.Show();
  Form1.Hide();
end;

procedure TForm1.FormCreate(Sender: TObject);
begin

end;



end.

