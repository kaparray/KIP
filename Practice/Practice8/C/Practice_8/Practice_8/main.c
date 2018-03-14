//
//  main.c
//  Practice_8
//
//  Created by Kirill on 27.02.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>

void swap(int *element1Ptr,int *element2Ptr) {
    int hold = *element1Ptr;
    *element1Ptr = *element2Ptr;
    *element2Ptr = hold;
}



int main(int argc, const char * argv[]) {
    
    int task_num = 0;
    int n,m;
    
    
    puts("\nПривет, это восьмая задача в практики программировании!");
    
    puts("\n**********************************************************\n");
    puts("Task :");
    puts("Дана прямоугольная матрица. Сформировать из положительных элементов матрицы, расположенных в первой и последней строках, новый одномерный массив. Полученный массив сортировать в порядке убывания элементов.");
   
    puts("**********************************************************\n");
    puts("");
    
    n = rand() % 10;
    m = rand() % 10;
    
    printf("m = %d\n", m);
    printf("n = %d\n", n);
    
    int **array;
    array = (int**)malloc(sizeof(int*)*m);
    
    for(int i = 0; i < m; i++){
        array[i] = (int*)malloc(sizeof(int)*n);
        for (int j = 0; j < n; j++){
            array[i][j] = rand() % 100 - 50;
        }
    }
    puts("Массив задан :)");
    
    for(int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            printf("%d ", array[i][j]);
        }
        puts("");
    }
    
    
    
    int *arrayn;
    arrayn = (int*)malloc(sizeof(int*)*n*2);
    
    puts("\n\n");
    for (int i = 0; i < n; i++){
        arrayn[i] = array[0][i];
        printf("%d ", arrayn[i]);
    }
    for (int i = n+1; i < n*2+1; i++){
        arrayn[i] = array[n][i];
        printf("%d ", arrayn[i]);
    }
    
    puts("\n\n");
    
    for (size_t pass = 0; pass < n*2 - 1; pass++) {
        for (size_t j = 0; j < n*2 - 1; j++) {
            if (arrayn[j] < arrayn[j + 1]) {
                swap( &arrayn[j], &arrayn[j + 1] );
            }
        }
    }

    for (int i = 0; i < n * 2; i++){
        printf("%d ", arrayn[i]);
    }
    
    
    
    puts("");
    return 0;
}
