// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.

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

bool IsPositionInMatrix(int rows, int columns, int[,] matrix){
    return rows > 0 && columns > 0 && rows <= matrix.GetLength(0) && columns <= matrix.GetLength(1);
}

int ElementInMatrix(int rows, int columns, int[,] matrix){
    return matrix[rows - 1, columns - 1];
}

int[,] matrix = GenerateMatrix(3, 4, -10, 11);
PrintMatrix(matrix);
System.Console.Write("Введите строку: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите столбец: ");
int column = Convert.ToInt32(Console.ReadLine());
if(IsPositionInMatrix(row, column, matrix)){
    System.Console.WriteLine(ElementInMatrix(row, column, matrix));
}
else System.Console.WriteLine("Заданного элемента нет в матрице.");