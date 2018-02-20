type TByteMultiMassiv = array of array of Byte;

var
      i,j,s,p,k,n,m, h:integer;
      byteMassiv: TbyteMultiMassiv;
    
begin
randomize;
writeln('2. Заполнить матрицу m*n. Найти сумму, количество и произведение нечетных элементов массива.');
write('Введите n: ');
ReadLn(n);
write('Введите m: ');
ReadLn(m);

setlength(byteMassiv, n);

for h:=low(byteMassiv) to High(byteMassiv) do 
  setlength(byteMassiv[h], m);



for i:=Low(byteMassiv) to High(byteMassiv) do
     for j:=Low(byteMassiv[i]) to High(byteMassiv[i]) do
         byteMassiv[i][j] := random(1000);
         
for i:=Low(byteMassiv) to High(byteMassiv) do
begin
     for j:=Low(byteMassiv[i]) to High(byteMassiv[i]) do
       begin
          write(byteMassiv[i][j] + ' ');  
       end;
       writeln();
       end;
          
s:=0;
p:=1;
k:=0;
for i:=Low(byteMassiv) to High(byteMassiv) do
     for j:=Low(byteMassiv[i]) to High(byteMassiv[i]) do
         if byteMassiv[i][j] mod 2 = 1 then
          begin
          inc(k);
          s:=s+byteMassiv[i][j];
          p:=p*byteMassiv[i][j];
          end;
writeln();
writeln('Сумма = ',s);
writeln('Кол-во = ',k);
writeln('Произведение = ',p);
end.
