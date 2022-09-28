// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int[,] GenerateMatrix(int rows, int columns, int min, int max){
    int[,] matrix = new int[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            matrix[i, j] = new Random().Next(min,max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void PrintArray(double[] array){
    for(int i = 0; i < array.Length; i++){
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

double[] AverageOfColumns(int[,] matrix){
    double[] average = new double[matrix.GetLength(1)];
    double sumOfColumn;
    for (int i = 0; i < matrix.GetLength(1); i++){
        sumOfColumn = 0;
        for (int j = 0; j < matrix.GetLength(0); j++){
            sumOfColumn += Convert.ToDouble(matrix[j, i]);
        }
        average[i] = sumOfColumn / matrix.GetLength(0);
    }
    return average;
}

int[,] matr = GenerateMatrix(4, 4, 0, 11);
PrintMatrix(matr);
PrintArray(AverageOfColumns(matr));