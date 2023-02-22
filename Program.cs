// See https://aka.ms/new-console-template for more information

// Домашнее задание к семинару 8 от 20.02.2023
//=====================================================================================================================
// Функция консольного меню

void myTaskMenu()
{
 bool exitNah=true; // переменная, обращение которой в true дает команду на выход из программы
    string selNum = "";

    Console.WriteLine("Welcome to HELL !!!");

    while (exitNah == true)
    {
    Console.Clear(); 
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("--------------------------------------------------------------------");
    Console.WriteLine("Представлены решения задач 54, 56, 58 и 60");
    Console.WriteLine("Введите номер задачи(либо q/Q для выхода):");
    Console.WriteLine("--------------------------------------------------------------------");
    for(int i=1; i <=5; i++) Console.WriteLine();
    Console.WriteLine();
    Console.Write($"Ваш выбор? : {selNum}");
    
    selNum = Console.ReadLine();
        switch(selNum)
        {
            case "54":
            {
                Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                
                Task_54();
                
                selNum = "";
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
                            
                break;
            }

            case "56":
            {    Console.WriteLine($"Выбрано : Задача {selNum}");
                Task_56();

                selNum = "";

                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }
            
             case "58":
            {    Console.WriteLine($"Выбрано : Задача {selNum}");
                Task_58();

                selNum = "";

                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }

            case "60":
            {    Console.WriteLine($"Выбрано : Задача {selNum}");
                Task_60();

                selNum = "";

                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }

            case "q":
            {
                exitNah = false;
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }

            case "Q":
            {
                exitNah = false;
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
            
                break;
            }
            default:
            {
                Console.WriteLine("Попробуйте еще раз. Есть шанс исправиться.");
                Console.WriteLine();
                Console.WriteLine();
                selNum = "";

                break;
            }
                
            
        }
    }
}

//============================================================================================
// Функция проверяет наличие принятого значения в указанном массиве (неповторяемость значений)

bool NoMatches(int newVol, int[] arrTest)
{
    bool noM = true;
    // распечатка проверочного массива-------------------------------------
                    // Console.Write("Проверочный массив: ");
                    // for(int m = 0; m < arrTest.Length; m++)
                    // {
                        
                    //     Console.Write($"{arrTest[m]}, ");
                    // }
                    // Console.WriteLine();
        
        for(int g = 0; g < arrTest.Length; g++)
            {
                if (arrTest[g] == newVol)
                {
                    //Console.WriteLine($"arrTest[g] = {arrTest[g]}, newVol = {newVol}");
                    noM = false;
                    // Console.WriteLine($"Попытка повторного внесения значения {newVol}");
                    // Console.WriteLine($"g = {g}");
                }
            }
        
    return noM;
}

//=====================================================================================================================
// Функция принимает число из консоли и обходит ошибку ввода
int IntInput(string intName) // функция принимает число из консоли, преобразуя его в целое
                             // зело ругаеццо при косячном вводе
{
    int num;

    Console.Write($"Введите число {intName}: ");
    while(!int.TryParse(Console.ReadLine(), out num))
    {
        Console.WriteLine("Ерунда какая-то... Ощущение, что введено не целое число.");
        Console.Write($"Ну-ка, еще разок! {intName} = ");
    }
    return  num;
}

//=====================================================================================================================
// Функция создает двумерный массив случайных целых чисел с заданным размером

int[,] makeArray(int rowNum, int colNum)
{
    int[,] tdArray = new int[rowNum, colNum];
    Random rnd = new Random();
    for (int i = 0; i <= rowNum-1; i++)
    {
        for (int j=0; j <= colNum-1; j++)
        {
            tdArray[i,j] = rnd.Next(0,10); //result[i, j] = Math.Round(rand.NextDouble() + 10, 2);
        }
    }
    return tdArray;
}

//=====================================================================================================================
// Функция выводит на экран содержимое двумерного массива
void printArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    //string stringRes;
    for (int i = 0; i <= rows-1; i++)
    {
        for (int j = 0; j <= columns-1; j++)
        {
            
            Console.Write(arr[i,j] + "  ");
        }    
        Console.WriteLine();
    }

    for(int i=1; i<3; i++) Console.WriteLine();
    
   
}



//=====================================================================================================================
// Функция сортирует по убыванию значения двумерного массива в указанной строке
void sortN(int[,] arr, int rowN)
{
    //int maxNum = 0;
    //int maxIndex = 0;
    int startIndex = 0;
    int tempField=0;
        
    while(startIndex < arr.GetLength(1))
    {
        for(int j = startIndex+1; j < arr.GetLength(1); j++)
        {
            if(arr[rowN,startIndex] < arr[rowN,j])
            {
                tempField = arr[rowN,j];
                arr[rowN,j] = arr[rowN,startIndex];
                arr[rowN,startIndex] =tempField;
                
            }
        }
    startIndex++;
   }
}

//=====================================================================================================================
// Функция возвращает номер строки двумерного массива с наименьшей суммой значений элементов
int FindMinSumRow(int[,] arr)
{
    int minSumValue = 0;
    int minRowNumber=0;
    int rowSum = 0;
    printArray(arr);
    
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        minSumValue=minSumValue+arr[0,j];
        rowSum = rowSum + arr[0,j];
    }
    Console.WriteLine($"{0+1}-я строка: {arr[0,0]} + {arr[0,1]} + {arr[0,2]} + {arr[0,3]} = {rowSum}");

    for(int i = 1; i < arr.GetLength(0); i++)
    {
        rowSum = 0;
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            
            rowSum = rowSum + arr[i,j];
          
                        
        }

        Console.WriteLine($"{i+1}-я строка: {arr[i,0]} + {arr[i,1]} + {arr[i,2]} + {arr[i,3]} = {rowSum}");

        if (rowSum < minSumValue) 
            {
                minSumValue = rowSum;
                minRowNumber = i ;
            }
            
    }
    //Console.ReadLine();
    return minRowNumber;
}

//================================================================================================================================
// Функция умножает двумерную матрицу (массив) arr1 на матрицу arr2, результат возвращает в матрице arr3
int[,] MultiplyABmatrix(int[,] arr1, int[,] arr2, int[,] arr3)
{
    int rCount = arr3.GetLength(0);
    int cCount = arr3.GetLength(1);

    for(int i = 0; i < rCount;i++)
    {
        for(int j = 0; j < cCount; j++)
        {
            arr3[i,j] = 0;
            for(int m = 0; m < arr1.GetLength(0); m++)
            {
                
                    arr3[i,j] = arr3[i,j] + (arr1[m,j] * arr2[i,m]);
            
            }
            Console.WriteLine($"arr3[{i},{j}] = {arr3[i,j]}");
        }

    }
    return arr3;
}

//==== Задача 54: =================================================================================================================
//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
void Task_54()
{
    Console.WriteLine("==== Задача 54: =======================================================================================");
    Console.WriteLine("Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию");
    Console.WriteLine("элементы каждой строки двумерного массива.");
    Console.Clear();
    
    int[,] array = makeArray(3, 4);
    Console.WriteLine("Исходный массив:");
    printArray(array);

    PauseString();

    int rowNum=array.GetLength(0);
    int colNum=array.GetLength(1);
    int max = array[0,0];
    
    for(int j = 0; j < colNum; j++)
    {
        for(int i = 0; i < rowNum; i++)
        {
           sortN(array, i);
        }

    }
    Console.WriteLine("Отсортированный: ");
    printArray(array);
    PauseString();

}

//==== Задача 56: =================================================================================================================
// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
void Task_56()
{
    int rCount = 3;
    int cCount = 4;
    int[,] array = makeArray(rCount, cCount);

    int minSumRow = FindMinSumRow(array);
    
    //Console.Clear();
    Console.WriteLine();

    //printArray(array);
    Console.WriteLine();
    Console.WriteLine($"Строка с индексом {minSumRow} ({minSumRow+1}-я сверху) имеет минимальную сумму значений элементов");
    Console.WriteLine();
    
    //Console.WriteLine("Для продолжения нажмите Enter...");
    PauseString();
}


// == Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void Task_58()
{
    int rCount = 2;
    int cCount = 2;
    
    
    int[,] array1 = makeArray(rCount, cCount);
    int[,] array2 = makeArray(rCount, cCount);
    Console.WriteLine("тест на эталонных данных---------------------------");
    
    array1[0,0] = 2;
    array1[0,1] = 4;
    array1[1,0] = 3;
    array1[1,1] = 2;

    
    array2[0,0] = 3;
    array2[0,1] = 4;
    array2[1,0] = 3;
    array2[1,1] = 3;


    int[,] array3 = new int [rCount, cCount];

        Console.WriteLine($"Матрица 1:");
    printArray(array1);

    Console.WriteLine($"Матрица 2:");
    printArray(array2);

    array3 = MultiplyABmatrix(array1, array2, array3);
    Console.WriteLine();
    Console.WriteLine("Результат на тестовых данных---------");
    Console.WriteLine($"Результирующая матрица 3:");
    printArray(array3);

    PauseString();

    Console.WriteLine("тест на случайных сгенерированных данных---------------------------");

    int[,] array4 = makeArray(rCount, cCount);
    int[,] array5 = makeArray(rCount, cCount);
    int[,] array6 = new int [rCount, cCount];

    Console.WriteLine($"Матрица 1:");
    printArray(array4);

    Console.WriteLine($"Матрица 2:");
    printArray(array5);

    array6 = MultiplyABmatrix(array4, array5, array6);

    Console.WriteLine();
    Console.WriteLine("Результат на случайных сгенерированных данных");
    printArray(array6);
    
     PauseString();
}

// Задача 60 ==============================================================================================
// Сформировать трёхмерный массив из неповторяющихся двузначных чисел. 
// Написать программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

void Task_60()
{
    int rCount = 2;
    int cCount = 2;
    int sCount = 2;
    int newValue;
    int numOfValuesInTestArr = 0;
    int nVcount = 0;

    Console.WriteLine();
    Random rnd = new Random();
    int t = 0;
    int[,,] arr3D = new int[rCount,cCount,sCount];
    int[] testArr = new int[rCount * cCount * sCount];
    int testArrCounter = 0;
    for(int i = 0; i < arr3D.GetLength(0); i++)
    {
        for(int j = 0; j < arr3D.GetLength(1); j++)
        {
            for(int g = 0; g < arr3D.GetLength(2); g++)
            {
                
                
                newValue = rnd.Next(1,10);
                nVcount++;
                
                while(!NoMatches(newValue, testArr))
                {                    
                    newValue = rnd.Next(1,10);
                    nVcount++;
                }

                testArr[numOfValuesInTestArr] = newValue;
                numOfValuesInTestArr++;
                arr3D[i,j,g] = newValue;
                Console.WriteLine($"Элемент массива с индексом [{i},{j},{g}] равен {arr3D[i,j,g]}");

            }
        }
        
    }

    Console.WriteLine();
    Console.WriteLine($"Количество генераций: {nVcount}");
    PauseString();
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

void Task_62()
{
    //1. создать массив 4х4
    //2. указать старт
    //3. указать направление (строка или колонка)
    //4. если нет возможности увеличивать номер следующего индекса - то уменьшать
    // критерии невозможности: элемент не нулевой, элемент выходит за рамки массива
    //5. критерий завершения - количество заполненных элементов массива (16)
int rCount = 4; // количество строк массива
int cCount = 4; // количество колонок массива
int CellsCount = rCount * cCount;
string moveDirection = "row"; // либо "col" - в зависимости от выбранного направления
int currentR = 0; // номер текущей строки
int currentC = 0; // номер текущей колонки


int[,] array = new int[rCount,cCount];
array[0,0] = 1; // [0,0] - стартовая ячейка,имеет значение, равное 1
int FilledCellsCount = 1; // количество заполненных элементов массива

while(FilledCellsCount <= CellsCount)
{
    switch(moveDirection)
    {
        case "row":
        {
            if((currentC+1) < (rCount-1) & array[currentR,currentC+1] == 0)
            {
                FilledCellsCount++;
                array[currentR,currentC+1] = FilledCellsCount;
                currentC++;
                break;
            
            
                if ((currentC-1) > 0 & array[currentC-1,currentR] == 0)
                {
                    FilledCellsCount++;
                    array[currentR,currentC-1] = FilledCellsCount;
                    currentC--;
                    break;
                }
            }    
            else
            {
                moveDirection = "col";    
            }

            

            break;
        }

        case "col":
        {

            break;
        }
    }   
}


}

void PauseString()
{
    Console.WriteLine("Для продолжения нажмите Enter...");
    Console.ReadLine();
}

    myTaskMenu();
   
  
