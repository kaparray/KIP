//
//  main.c
//  Practice_3
//
//  Created by Kirill on 13.02.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>

int main(int argc, const char * argv[]) {
    int task_num = 0;
    
    puts("\nПривет, это третья задача в практики программировании!");
    
    puts("\n**********************************************************\n");
    puts("Task :");
    
    puts("1.    Составьте блок-схему и программу для нахождения суммы, произведения и среднего арифметического натуральных двузначных чисел, кратных 10.");
    puts("");
    puts("");
    puts("**********************************************************\n");
    printf("Введите номер задачи (числ 1-3, если вы вводите в программу не число то она закроется): ");
    
    while(scanf("%d",&task_num) == 1){
        if(task_num == 1){
            int i = 1, count = 0;
            int sum = 0, arifm = 0, proizved = 0;
            
             puts("1.    Составьте блок-схему и программу для нахождения суммы, произведения и среднего арифметического натуральных двузначных чисел, кратных 10.");
            for (i; i < 100; i++){
                if (i % 10 == 0){
                    count ++;
                    sum += i;
                    arifm += i;
                    proizved *= i;
                }
            }
            printf("%s%d%s%d%s%d", "Cумма = ", sum, " произведение = ", proizved, " среднее арифметическое = ", arifm / count);
        }else if (task_num == 2){
            float n = 1;
            float e, summ = 0.0f, num = 1.0f;
    
            printf("%s", "Введите число e: ");
            scanf("%f", &e);
            
            while(fabsl(num) >= e){
                num = 1 / n;
                summ += num;
                printf("%f %f\n", summ, num);
                n++;
            }
            printf("Сумма равна %f", summ);
        }else{
              printf("%s", "Вы выбоали не верный пункт меню!\n");
        }
        
         printf("\nВведите номер задачи: ");
    }
    puts("Пока! Возвращайся :)");
    return 0;
}
