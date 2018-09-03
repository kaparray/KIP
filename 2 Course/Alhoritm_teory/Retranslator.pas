var
    k: integer;
    s: byte;
 
procedure scale (a: integer; b: byte);
    begin
        if b > 10 then
            write ('Основание должно быть меньше 10!')
        else begin
            if a > 1 then
                scale (a div b, b);
            write (a mod b)
        end;
    end;
 
begin
 
    write ('Введите число: ');
    readln (k);
 
 
 
    scale (k, -2);
 
readln
end.