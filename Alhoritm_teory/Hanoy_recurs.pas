type
    st = (left, middle, right);
    nat = 1..maxint;
 
var
    m: nat; {m – число дисков}
 
procedure move(n: nat; s1, sw, sk: st);
{перемещение n дисков с s1 на sk}
 
    procedure step;
    {перемещение одного диска с s1 на sk}
 
        procedure print(s: st);
            begin
                case s of
                    left: write(' лев. ');
                    middle: write(' средн. ');
                    right: write(' прав. ')
                end;
            end;
 
        begin {step}
            write(' снять диск с ');
            print(s1);
            write(' надеть на  ');
            print(sk);
            writeln
        end;
 
    begin {move}
        if n = 1 then
            step
        else begin
            move(n - 1, s1, sk, sw);
            step;
            move(n-1, sw, s1, sk)
        end
    end;
 
begin
    read(m); {число дисков}
    writeln('для ', m:3, ' дисков следует произвести ',
    'следующие действия:');
    move(m, left, middle, right);
 
readln
end.