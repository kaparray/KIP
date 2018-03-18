//
//  main.c
//  Practice_12
//
//  Created by Kirill on 15.03.2018.
//  Copyright © 2018 Kirill. All rights reserved.
//

#include <stdio.h>

void filecopy(FILE *ifp, FILE *ofp)
{
    int c;
    while ((c = getc(ifp)) != EOF)
        putc(c, ofp);
}

int main(int argc, const char * argv[]) {
   
    int input_type;
    
    
    puts("\nПривет, это десятая задача в практики программировании!");
    
    puts("\n**********************************************************\n");
    puts("Task :");
    puts("Найти среднее арифметическое неотрицательных элементов матрицы, а также подсчитать, сколько таких элементов в каждой отдельно взятой строке матрицы.");
    
    puts("**********************************************************\n");
    puts("");
    puts("1 - руками");
    puts("2 - рандом");
    puts("**********************************************************\n");
    puts("");
    printf("Введите номер типа ввода данных (числа 1-3, если вы вводите в программу не число то она закроется): ");
    
    while (scanf("%d", &input_type) == 1){
        if(input_type == 1){
            int len_matrix = 0;
            int len_array = 0;
            int count = 0;
            int summCount = 0;
            
            printf("\n%s", "Введите длину матрицы: ");
            scanf("%d", &len_matrix);
            printf("%s", "Введите длину матрицы: ");
            scanf("%d", &len_array);
            
            // Create array
            int matrix[len_matrix][len_array];
            int count_negative[len_matrix];
            
            puts("Заполняем массив!");
            
            for(int i = 0; i < len_matrix; i++){
                int castomCount = 0;
                for(int j = 0; j < len_array; j++){
                    printf("Ввидите элемент [%d][%d]: ", i, j);
                    scanf("%d", &matrix[i][j]);
                    if (matrix[i][j] >= 0){
                        count++;
                        castomCount++;
                        summCount += matrix[i][j];
                    }
                }
                count_negative[i] = castomCount;
            }
            
            if (count != 0){
                printf("Среднее арифметическое неотрицательных элементов матрицы = %d\n", summCount/count);
            } else {
                printf("Среднее арифметическое неотрицательных элементов матрицы = %d\n", 0);
            }
            for (int i = 0; i < len_matrix; i++){
                printf("Неотрицательных элементов в строке №%d = %d\n", i,count_negative[i]);
            }
            
            
        } else if(input_type == 2){
            int len_matrix = 0;
            int len_array = 0;
            int count = 0;
            int summCount = 0;
            
            
            len_matrix = rand() % 10;
            printf("\n%s = %d", "Длина матрицы", len_matrix);
            len_array = rand() % 10;
            puts("");
            printf("%s = %d", "Длина матрицы", len_array);
            // Create array
            int matrix[len_matrix][len_array];
            int count_negative[len_matrix];
            
            puts("\nЗаполняем массив!");
            
            for(int i = 0; i < len_matrix; i++){
                int castomCount = 0;
                for(int j = 0; j < len_array; j++){
                    matrix[i][j] = rand() % 100 - 50;
                    printf("%4d ",matrix[i][j]);
                    if (matrix[i][j] >= 0){
                        count++;
                        castomCount++;
                        summCount += matrix[i][j];
                    }
                }
                count_negative[i] = castomCount;
                puts("");
            }
            
            if (count != 0){
                printf("Среднее арифметическое неотрицательных элементов матрицы = %d\n", summCount/count);
            } else {
                printf("Среднее арифметическое неотрицательных элементов матрицы = %d\n", 0);
            }
            for (int i = 0; i < len_matrix; i++){
                printf("Неотрицательных элементов в строке №%d = %d\n", i,count_negative[i]);
            }
            
        
        } else if (input_type == 3){
            // Говно собачье 
//            int ch = 0;
//            FILE *fp;
//
//
//            fp = fopen("m","r");
//
//            while((ch=getc(fp)!=EOF)){
//                if(ch=='a')ch=" ";
//            }
//
//            printf("%c", ch);
//
//            int fclose(FILE *fp);
        }
    } // for while
    
    return 0;
}
