//
//  main.c
//  Practice_5
//
//  Created by Kirill on 20.02.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>

int main(int argc, const char * argv[]) {
    int task_num = 0;
    
    puts("\nПривет, это пятая задача в практики программировании!");
    
    puts("\n**********************************************************\n");
    puts("Task :");
    puts("1.    Сформируйте и выведите на экран массив из n элементов, где каждый элемент массива равен предыдущему, увеличенному в 2 раза + порядковый номер элемента.");
    puts("2.    Задайте массив из n элементов. Элементы, большие 55, заменить на максимальный. Выведите на экран исходный и полученный массив.");
    puts("**********************************************************\n");
    puts("");
    printf("Введите номер задачи (числ 1-2, если вы вводите в программу не число то она закроется): ");
    
    while(scanf("%d",&task_num) == 1){
        if(task_num == 1){
            int how = 0;
            printf("%s", "Введите способ генирации (1 - stok, 2 - random): ");
            scanf("%d", &how);
            if (how == 1){
                int n = 0;
                int start = 0;
                int startNum = 0;
                printf("%s", "Введите длину массива: ");
                scanf("%d", &n);
                // create array
                int array[n];
                printf("%s", "Введите первый элемент: ");
                scanf("%d", &startNum);
                for (int i = 0; i < n; i++){
                    if (start == 0){
                        array[i] = startNum;
                        start = 1;
                    } else {
                        array[i] = array[i - 1] * 2 + i;
                    }
                }
                //output array
                for (int i = 0; i < n; i++){
                    printf("%d ", array[i]);
                }
            } else if (how == 2){
                //int r = rand() % 20;
                int n = 0;
                int start = 0;
                int startNum = 0;
                printf("%s", "Введите длину массива: ");
                scanf("%d", &n);
                // create array
                int array[n];
               startNum = rand() % 100;
                for (int i = 0; i < n; i++){
                    if (start == 0){
                        array[i] = startNum;
                        start = 1;
                    } else {
                        array[i] = array[i - 1] * 2 + i;
                    }
                }
                //output array
                for (int i = 0; i < n; i++){
                    printf("%d ", array[i]);
                }
            }
        } else if (task_num == 2){
            int how = 0;
            printf("%s", "Введите способ генирации (1 - stok, 2 - random): ");
            scanf("%d", &how);
            if (how == 1){
                int maxVal = 0;
                int n = 0;
                printf("%s", "Введите длину массива: ");
                scanf("%d", &n);
                int array[n];
                // input array
                for (int i = 0; i < n; i++){
                    printf("Введите элемент номер [%d]: " , i);
                    scanf("%d", &array[i]);
                }
                // copy array
                int arrayCopy[n];
                for (int i = 0; i < n; i++){
                    arrayCopy[i] = array[i];
                }
                //max in array
                for (int i = 0; i < n; i++){
                    if (array[i] > maxVal){
                        maxVal = array[i];
                    }
                }
                // refactor array
                for (int i = 0; i < n; i++){
                    if (array[i] > 55){
                        array[i] = maxVal;
                    }
                }
                puts("Старый массив: ");
                for (int i = 0; i < n; i++){
                    printf("%d ", arrayCopy[i]);
                }
                puts("\nНовый массив: ");
                for (int i = 0; i < n; i++){
                    printf("%d ", array[i]);
                }
            } else if(how == 2){
                int maxVal = 0;
                    int n = 0;
                    printf("%s", "Введите длину массива: ");
                    scanf("%d", &n);
                    int array[n];
                    // input array
                    for (int i = 0; i < n; i++){
                        array[i] = rand() % 100;
                    }
                    // copy array
                    int arrayCopy[n];
                    for (int i = 0; i < n; i++){
                        arrayCopy[i] = array[i];
                    }
                    //max in array
                    for (int i = 0; i < n; i++){
                        if (array[i] > maxVal){
                            maxVal = array[i];
                        }
                    }
                    // refactor array
                    for (int i = 0; i < n; i++){
                        if (array[i] > 55){
                            array[i] = maxVal;
                        }
                    }
                    puts("Старый массив: ");
                    for (int i = 0; i < n; i++){
                        printf("%d ", arrayCopy[i]);
                    }
                    puts("\nНовый массив: ");
                    for (int i = 0; i < n; i++){
                        printf("%d ", array[i]);
                    }
                }
            }
        }
    
    return 0;
}
