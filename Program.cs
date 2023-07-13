//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочивает
// по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

Console.Write("Введите размерность m массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива:");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];

void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.NextDouble();
            Console.Write($"{randomArray[i,j]:F2}  ");
        }
    }
}
void maxarr(int m, int n)
{
    int i,j,k;
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n + 1; j++)
        {
            for  (k = 0; k < n - 1 ; k++)
            {
               if (randomArray[i,k] < randomArray[i,k+1])
               {
                double temp = randomArray[i, k + 1];
                randomArray[i, k + 1] = randomArray[i, k];
                randomArray[i, k] = temp;
               }
            }        
        }   
    }
    Console.WriteLine();
}

void printmax(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            Console.Write($"{randomArray[i,j]:F2}  ");
        }
    }
}

mas(m,n);
maxarr(m,n);
printmax(m,n);
