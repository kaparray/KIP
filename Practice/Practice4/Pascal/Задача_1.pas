//fpc 3.0.0

program Practice_4_1;


var 
	a : array of Integer;
	arrayLen, startNum, i: Integer; 
	run: Boolean;

begin 
	run := true;
	WriteLn('1.	Сформируйте и выведите на экран массив из n элементов, где каждый элемент массива равен предыдущему, увеличенному в 2 раза + порядковый номер элемента.');
	Write('Введите длину массива: ');
	ReadLn(arrayLen);
	
	Write('Укажите номер первого элемента: ');
	ReadLn(startNum);
    SetLength(a, arrayLen);
    
	for i:=Low(a) to High(a) do 
		begin
			if (run) then
			begin
				a[i] := startNum;
				run := false;
			end
			else
				a[i]:= a[i-1]*2+1;
		end;
  WriteLn(a);
end.