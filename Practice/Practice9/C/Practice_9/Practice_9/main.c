#include <stdio.h>
#include <stdlib.h>

int main()
{
    int a[10][10],i,j,k,p;
    for(i=0;i<10;i++)
    {
        for(j=0;j<10;j++)
        {
            a[i][j] = rand()%25; printf("%3d",a[i][j]);
        }
        printf("\n");
    }
    printf("\n");
    for(k=0;k<10;k++)
    {
        for(j=0;j<10-k-1;j++)
        {
            if(a[9][j]>a[9][j+1])
            {
                for(i=0;i<10;i++)
                {
                    p = a[i][j];
                    a[i][j] = a[i][j+1];
                    a[i][j+1] = p;
                }
            }
        }
    }
    for(i=0;i<10;i++)
    {
        for(j=0;j<10;j++)
        {
            printf("%3d",a[i][j]);
        }
        printf("\n");
    }
    return 0;
}

