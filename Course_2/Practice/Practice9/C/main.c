#include <stdio.h>
#include <stdlib.h>



int main(void){
    
    int n,m;
    
    
    puts("\nПривет, это девятая задача в практики программировании!");
    
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
    for (int i = 0; i < 10; i++){
        arrayn[i] = array[0][i];
        printf("%d ", arrayn[i]);
        j++;
    }
    for (int i = 0; i < 10; i++){
        arrayn[j] = array[n-1][i];
        printf("%d  ", array[n-1][i]);
        j++;
    }
    
    
    // Start sorrted
    for (int i = 0; i < 20 - 1; i++) {
        /* устанавливаем начальное значение минимального индекса */
        int min_i = i;
        /* находим индекс минимального элемента */
        for (int j = i + 1; j < 20; j++) {
            if (arrayn[j] < arrayn[min_i]) {
                min_i = j;
            }
        }
        /* меняем значения местами */
        int temp = arrayn[i];
        arrayn[i] = arrayn[min_i];
        arrayn[min_i] = temp;
    }
    
    
    puts("\n\n\n");
    printf("%s", "Отсортированный одномерный массив: \n");
    
    for (int i = 0; i < 20; i++){
        printf("%d ", arrayn[i]);
    }
    puts("");
    return 0;
}

