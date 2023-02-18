// Домашнее задание к семинару 7 от 16.02.2023
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
    Console.WriteLine("Представлены решения задач 47, 50 и 52");
    Console.WriteLine("Введите номер задачи(либо q/Q для выхода):");
    Console.WriteLine("--------------------------------------------------------------------");
    for(int i=1; i <=5; i++) Console.WriteLine();
    Console.WriteLine();
    Console.Write($"Ваш выбор? : {selNum}");
    
    selNum = Console.ReadLine();
        switch(selNum)
        {
            case "47":
            {
                Console.Write($"Выбрано : Задача {selNum}");
                Console.Clear(); 
                Console.WriteLine();
                
                Task_47();
                
                selNum = "";
                Console.Clear(); 
                for(int i = 1; i <= 3; i++) Console.WriteLine();
                            
                break;
            }

            // case "50":
            // {    Console.WriteLine($"Выбрано : Задача {selNum}");
            //     Task_50();

            //     selNum = "";

            //     Console.Clear(); 
            //     for(int i = 1; i <= 3; i++) Console.WriteLine();
            
            //     break;
            // }
            
            //  case "52":
            // {    Console.WriteLine($"Выбрано : Задача {selNum}");
            //     Task_52();

            //     selNum = "";

            //     Console.Clear(); 
            //     for(int i = 1; i <= 3; i++) Console.WriteLine();
            
            //     break;
            // }

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
// Функция создает двумерный массив случайных вещественных чисел с заданным размером

double[,] makeArray(int rowNum, int colNum)
{
    double[,] tdArray = new double[rowNum, colNum];
    Random rnd = new Random();
    for (int i = 0; i <= rowNum-1; i++)
    {
        for (int j=0; j <= colNum-1; j++)
        {
            tdArray[i,j] = rnd.Next();
        }
    }
    return tdArray;
}

//=====================================================================================================================
// Функция выводит на экран содержимое двумерного массива
void printArray(double[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    for (int i = 0; i <= rows-1; i++)
    {
        for (int j = 0; j <= columns-1; j++)
        {
            Console.Write(arr[i,j] +  " ");
        }
        Console.WriteLine();
    }
}

//==== Задача 47 =================================================================================================================
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
void Task_47()
{
    double[,] array = makeArray(3, 4);
    printArray(array);

    PauseString();
}
    
void PauseString()
{
    Console.WriteLine( "Для продолжения нажмите 'Ввод'...");
    Console.ReadLine();
}

    myTaskMenu();
