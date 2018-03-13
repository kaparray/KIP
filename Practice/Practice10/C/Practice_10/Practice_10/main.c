//
//  main.c
//  Practice_10
//
//  Created by Kirill on 13.03.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>

int main(int argc, const char * argv[]) {
    
    int n,m;
    
    
    puts("\nПривет, это десятая задача в практики программировании!");
    
    puts("\n**********************************************************\n");
    puts("Task :");
    puts("Дана прямоугольная матрица. Сформировать из положительных элементов матрицы, расположенных в первой и последней строках, новый одномерный массив. Полученный массив сортировать в порядке убывания элементов.");
    
    puts("**********************************************************\n");
    puts("");
    
    n = 10;
    m = 10;
    
    
    int **array;
    array = (int**)malloc(sizeof(int*)*m);
    
    for(int i = 0; i < m; i++){
        array[i] = (int*)malloc(sizeof(int)*n);
        for (int j = 0; j < n; j++){
            array[i][j] = rand() % 100 - 50;
        }
    }
    
    puts("Массив задан :)\n");
    printf("%s", "Оригинальный двумерный массив: \n");
    
    for(int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            printf("%d ", array[i][j]);
        }
        puts("");
    }
    
    
    
    puts("\n\n");
    printf("%s", "Оригинальный одномерный массив: \n");
    
    int arrayn[n*2];
    int j = 0;
    for (int i = 0; i < n; i++){
        arrayn[i] = array[0][i];
        printf("%d ", arrayn[i]);
        j++;
    }
    for (int i = 0; i < n; i++){
        arrayn[j] = array[n-1][i];
        printf("%d  ", array[n-1][i]);
        j++;
    }
    
    
    int hold;
    // Start sorrted
    for (int pass = 0; pass < n*2-1; pass++){
        for (int j = pass+1; j < n*2; j++){
            if (arrayn[pass]>arrayn[j]){
                hold = arrayn[j];
                arrayn[j] = arrayn[pass];
                arrayn[pass] = hold;
            }
        }
    }

    
    
    puts("\n\n\n");
    printf("%s", "Отсортированный одномерный массив: \n");
    
    for (int i = 0; i < n*2; i++){
        printf("%d ", arrayn[i]);
    }
    puts("");
    
    return 0;
}



