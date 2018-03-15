//
//  main.c
//  Igor_practice_9
//
//  Created by Kirill on 15.03.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//


#include <stdio.h>

int main(int argc, const char * argv[]) {
    int mas[20];
    int negative_num = 0;
    printf("Массив:\n");
    for (int i = 0; i < 20; i++)
    {
        mas[i] = rand() % 20 - 10;
        printf("%d ", mas[i]);
        if (mas[i] < 0){
            negative_num++;
        }
    }
    
    int new_negative_array[negative_num];
    int j = 0;
    for(int i = 0; i < 20; i++){
        if (mas[i] < 0){
            new_negative_array[j] = mas[i];
            j++;
        }
    }
    
    // Start sorrted
    for (int i = 0; i < 20 - 1; i++) {
        /* устанавливаем начальное значение минимального индекса */
        int min_i = i;
        /* находим индекс минимального элемента */
        for (int j = i + 1; j < 20; j++) {
            if (new_negative_array[j] > new_negative_array[min_i] && new_negative_array[j] < 0) {
                min_i = j;
            }
        }
        /* меняем значения местами */
        int temp = new_negative_array[i];
        new_negative_array[i] = new_negative_array[min_i];
        new_negative_array[min_i] = temp;
    }
    
    
    puts("\n\n");
    j = 0;
    for (int i = 0; i < 20; i++)
    {
        if (mas[i] < 0){
            printf("%d ", new_negative_array[j]);
            j++;
        }else {
            printf("%d ", mas[i]);
        }
    }
    
    return 0;
}


