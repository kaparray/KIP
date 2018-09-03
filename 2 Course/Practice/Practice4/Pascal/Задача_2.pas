program Practice_4_2;

var 
  a, a1 : array of Integer;
  n,arrayLen: Integer;
  i, nn, max : Integer;
  
  
begin

  WriteLn('2.	Задайте массив из n элементов. Элементы, большие 55, заменить на максимальный. Выведите на экран исходный и полученный массив.');

  Write('Введите длину массива: ');
	ReadLn(arrayLen);
	SetLength(a, arrayLen);
  SetLength(a1, arrayLen);
  
  
	for i:= Low(a) to High(a) do
	begin
	  Write('Введите элемент массива: ');
	  ReadLn(nn);
	  a[i] := nn
	end;
	
	
	for i:= Low(a) to High(a) do
	begin
	 if (a[i] > max) then 
	 begin
	 max := a[i];
	 end
	  
	end;
	
	for i:= Low(a1) to High(a1) do
	begin
	 a1[i] := a[i];
	  
	end;

	
	for i:= Low(a1) to High(a1) do
	begin
	 if (a1[i] >= 55) then 
	 begin
	 a1[i] := max;
	 end
	  
	end;
	
	Write('Старый ');
	WriteLn(a);
	Write('Новый ');
	Writeln(a1);
end.