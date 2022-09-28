// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

double[,] GenerateMatrix(int rows, int columns, int min, int max){
    double[,] matrix = new double[rows, columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j < columns; j++){
            double randomNum = new Random().Next(min,max);
            randomNum += Convert.ToDouble(new Random().Next(0, 10)) / 10;
            matrix[i, j] = randomNum;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++){
        for(int j = 0; j < matrix.GetLength(1); j++){
            System.Console.Write($"{matrix[i,j]}\t");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

double[,] matrix = GenerateMatrix(3, 4, -10, 10);
PrintMatrix(matrix);