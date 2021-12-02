//55.Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Random rnd = new Random(); 
int [,] array = new int [3,3]; 
double averige0; 
double averige1; 
double averige2; 
 
void CreateArray(int [,] array) 
{ 
    for(int i =0; i <array.GetLength(0); i++ ) 
    { 
        for(int j=0; j <array.GetLength(1); j++) 
        { 
            array[i,j] = rnd.Next(1,10); 
        } 
    } 
} 
void PrintArray(int [,] array) 
{ 
    for(int i =0; i <array.GetLength(0); i++ ) 
    { 
        for(int j=0; j <array.GetLength(1); j++) 
        { 
            Console.Write($" {array[i,j],4}"); 
        } 
    Console.WriteLine(); 
    } 
} 
void  Average(int [,] array, out double averige0, out double averige1, out double averige2) 
{ 
    int sum0 = 0; 
    int sum1 = 0; 
    int sum2 = 0; 
    for(int i =0; i <array.GetLength(0); i++ ) 
    { 
        for(int j=0; j <array.GetLength(1); j++) 
        { 
            if(j==0) sum0 = sum0 + array[i,j]; 
            if(j==1) sum1 = sum1 + array[i,j]; 
            if(j==2) sum2 = sum2 + array[i,j]; 
        } 
    } 
    averige0 = sum0/array.GetLength(0); 
    averige1 = sum1/array.GetLength(0); 
    averige2 = sum2/array.GetLength(0); 
} 
CreateArray(array); 
PrintArray(array); 
Average(array, out averige0, out averige1, out averige2); 
Console.WriteLine($"среднее арифметическое 1 столбца {averige0}"); 
Console.WriteLine($"среднее арифметическое 2 столбца {averige1}"); 
Console.WriteLine($"среднее арифметическое 3 столбца {averige2}");