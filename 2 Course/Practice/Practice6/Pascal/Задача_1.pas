program massiv10;

type TByteMultiMassiv = array of array of Byte;

var
    byteMassiv: TbyteMultiMassiv;
    I, J,N,M,h, ii:integer;
begin

writeln('1. Заполнить случайными числами матрицу n*m. Вывести на печать вторую строку массива.');
write('Введите n: ');
ReadLn(N);
write('Введите m: ');
ReadLn(M);

setlength(byteMassiv, n);

for h:=low(byteMassiv) to High(byteMassiv) do 
  setlength(byteMassiv[h], m);

randomize;
for i:=Low(byteMassiv) to High(byteMassiv) do
    for j:=Low(byteMassiv[i]) to High(byteMassiv[i]) do
    byteMassiv[i, j] := random(100);
    
for i:=Low(byteMassiv) to High(byteMassiv) do
begin
  for j:=Low(byteMassiv[i]) to High(byteMassiv[i]) do
    write (' ',byteMassiv[i,j]);
    writeln
end;

for i:=Low(byteMassiv) to High(byteMassiv) do
begin

  write(byteMassiv[i][M-1], ' ');
end;



end.
