//
//  main.c
//  Practice_7
//
//  Created by Kirill on 27.02.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>

int main(int argc, const char * argv[]) {
    int task_num = 0;
    
    puts("\nПривет, это седьмая задача в практики программировании!");
    
    puts("\n**********************************************************\n");
    puts("Task :");
    puts("1.    Заполнить матрицу m*n с клавиатуры. Найти сумму, количество и произведение нечетных элементов массива.");
    puts("2.    Заполнить случайными числами матрицу n*m. Вывести на печать вторую строку массива.");
    puts("**********************************************************\n");
    puts("");
    printf("Введите номер задачи (числ 1-2, если вы вводите в программу не число то она закроется): ");
    
    while(scanf("%d",&task_num) == 1){
        if(task_num == 1){
            int n,m;
            int count = 0, summ= 0, arifm = 0;
            
            printf("%s", "Введите m: ");
            scanf("%d", &m);
            printf("%s", "Введите n: ");
            scanf("%d", &n);
            
            int **array;
            array = (int**)malloc(sizeof(int*)*m);
            
            for(int i = 0; i < m; i++){
                array[i] = (int*)malloc(sizeof(int)*n);
                for (int j = 0; j < n; j++){
                    printf("Введите [%d][%d] : ", i,j);
                    scanf("%d", &array[i][j]);
                }
            }
            puts("Массив задан :)");
            
            for(int i = 0; i < m; i++){
                for (int j = 0; j < n; j++){
                    if (array[i][j] % 2 == 1){
                        summ += array[i][j];
                        count++;
                        if (arifm == 0){
                            arifm = array[i][j];
                        } else{
                            arifm *= array[i][j];
                        }
                    }
                }
            }
            printf("Сумма = %d\n", summ);
            printf("Количество = %d\n", count);
            printf("произведение = %d\n", arifm);
        }else if(task_num == 2){
             int n,m;
            n = rand() % 10;
            m = rand() % 10;
            
            printf("m = %d\n", m);
            printf("n = %d\n", n);

            int **array;
            array = (int**)malloc(sizeof(int*)*m);
            
            for(int i = 0; i < m; i++){
                array[i] = (int*)malloc(sizeof(int)*n);
                for (int j = 0; j < n; j++){
                    array[i][j] = rand() % 100;
                }
            }
            puts("Массив задан :)");
            
            for(int i = 0; i < m; i++){
                for (int j = 0; j < n; j++){
                     printf("%d ", array[i][j]);
                }
                puts("");
            }
            puts("\n");
            for(int i = 0; i < n; i++){
                printf("%d ", array[1][i]);
            }
        }else {
            printf("%s", "Выввели не то число :)");
        }
        printf("\n%s","Введите номер задачи: ");
    }
    
    
    return 0;
}
