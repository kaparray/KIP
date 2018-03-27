//
//  main.c
//  HomeWork1
//
//  Created by Kirill on 18.03.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>
#include <math.h>

int x,y,c,d;

float castomMax(float num1, float num2) {
    if (num1 > num2) return num1;
    else  return  num2;
}

void getValue(float x, float y, float c, float d) {
    float xy = x * y;
    float cx = c * x;
    float dy = d * y;
    float answer = 0;
    
    if (xy > 3) {
        answer = x * x * x + pow(log10(xy), d*c);
    }
    else if (2 <= x && x <= 3) {
        if (x < y && x < x < castomMax(cx, dy)) {
            answer = 3 * x;
        }
        else if (y < x && y < castomMax(cx, dy)) {
            answer = 3 * y;
        }
        else if (castomMax(cx, dy) < x && castomMax(cx, dy) < y) {
            answer = 3 * castomMax(cx, dy);
        }
    }
    else if (xy < 0) {
        answer = pow(2, c*d) - x;
    }
    printf("Результат равен %f", answer);
}

void setValue(){
    puts("Введите 4 числа и  получеие ответ по формуле");
    printf("%s", "Введите x: ");
    scanf("%d", &x);
    printf("%s", "Введите y: ");
    scanf("%d", &y);
    printf("%s", "Введите c: ");
    scanf("%d", &c);
    printf("%s", "Введите d: ");
    scanf("%d", &d);
}

int main(int argc, const char * argv[]) {
    setValue();
    getValue(x,y,c,d);
    puts("");
    return 0;
}
