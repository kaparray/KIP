program Prac1_1;

var: 
	a,b,c,s, p:Integer;


begin 

	WriteLn("Введите a");
	ReadLn(a);
	WriteLn("Введите b");
	ReadLn(b);
	WriteLn("Введите c");
	ReadLn(c);

	p = (a + b + c) / 2;

	WriteLn("Ответ: " + sqrt(p * (p - a) * (p - b) * (p - c)));
end.