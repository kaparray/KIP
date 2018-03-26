program fibonachchi;
uses crt;

function fibch(n:integer): longint;
begin
  if n<=2 then
    fibch:=1
  else
    fibch:=fibch(n-1)+fibch(n-2)
end;


var i, n:integer;
begin
readln(n);
for i:=1 to n do writeln('fib(', i, ') = ', fibch(i) );
readkey;
end.