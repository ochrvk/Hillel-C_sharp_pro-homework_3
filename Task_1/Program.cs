/*
Завдання 1 

Створіть інтерфейс IOutput. 

У ньому мають бути два методи: 

■ void Show() — відображає інформацію; 

■ void Show(string info) — відображає інформацію та інформаційне повідомлення, зазначене у параметрі info. 

Створіть клас Array (масив цілого типу) із необхідними методами. 

Цей клас має імплементувати інтерфейс IOutput. 

Метод Show() — відображає на екран елементи масиву. 

Метод Show(string info) — відображає на екрані елементи масиву та інформаційне повідомлення, зазначене у параметрі info. 

Напишіть код для тестування отриманої функціональності.

 */

/*
    Завдання 2 
    Створіть інтерфейс IMath. 

    У ньому мають бути чотири методи: 

        ■ int Max() — повертає максимум; 

        ■ int Min() — повертає мінімум;

        ■ float Avg() — повертає середньоарифметичне; 

        ■ bool Search(int valueToSearch) — шукає valueSearch всередині контейнера даних. 

            - Повертає true, якщо значення знайдено. 

            - Повертає false, якщо значення не знайдено. 

    Клас, створений у першому завданні Array, має імплементувати інтерфейс IMath. 

    Метод Max — повертає максимум серед елементів масиву. 

    Метод Min — повертає мінімум серед елементів масиву. 

    Метод Avg — повертає середньоарифметичне серед елементів масиву. 

    Метод Search — шукає значення всередині масиву. 
    
        - Повертає true, якщо значення знайдено. 
    
        - Повертає false, якщо значення не знайдено. 

    Напишіть код для тестування отриманої функціональності
 */

/*
 Створіть інтерфейс ISort. 

    У ньому мають бути три методи: 

        ■ void SortAsc() — сортування за зростанням; 

        ■ void SortDesc() — сортування за зменшенням; 
    
        ■ void SortByParam(bool isAsc) — сортування залежно від переданого параметра. 

    Якщо isAsc дорівнює true, сортуємо за зростанням. 

    Якщо isAsc дорівнює false, сортуємо за зменшенням

    Клас, створений у першому завданні Array, має імплементувати інтерфейс ISort. 

    Метод SortAsc — сортує масив за зростанням. 

    Метод SortDesc — сортує масив за спаданням. 

    Спосіб SortByParam — сортує масив залежно від переданого параметра. 

    Якщо isAsc дорівнює true, сортуємо за зростанням. 

    Якщо isAsc дорівнює false, сортуємо за зменшенням. 

    Напишіть код для тестування отриманої функціональності.
 */

Task_1.Array array;
int lenght;
Init();

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine();
    Console.WriteLine("---Choose an option---");
    Console.WriteLine("1. Fill array");
    Console.WriteLine("2. SortAsc");
    Console.WriteLine("3. SortDesk");
    Console.WriteLine("4. SortByParam");
    Console.WriteLine("5. Show array");
    Console.WriteLine("6. Show array with info");
    Console.WriteLine("7. Min");
    Console.WriteLine("8. Max");
    Console.WriteLine("9. Average");
    Console.WriteLine("10. Search");
    Console.WriteLine("11. Exit");
    Console.Write(">>>");

    string key = Console.ReadLine();
    switch (key)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            FillArray();
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Green;
            array.SortAsc();
            break;
        case "3":
            array.SortDesc();
            break;
        case "4":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Asc(true) or Desk(false): ");
            array.SortByParam(boolInput());
            break;
        case "5":
            Console.ForegroundColor = ConsoleColor.Green;
            array.Show();
            break;
        case "6":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter info here: ");
            string info = Console.ReadLine();
            array.Show(info);
            break;
        case "7":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Min = " + array.Min());
            break;
        case "8":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Max = " + array.Max());
            break;
        case "9":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Average: " + array.Avg());
            break;
        case "10":
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Enter value here: ");
            Console.WriteLine(array.Search(Input()));
            break;
        case "11":
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong input! Please try again!");
            break;
    }
}

void Init()
{
    Console.Write("Enter array lenght: ");
    while (true)
    {
        try
        {
            lenght = int.Parse(Console.ReadLine());
            break;
        }
        catch
        {
            Console.WriteLine("Wrong input! Please try again: ");
        }
    }
    array = new Task_1.Array(lenght);
}
void FillArray()
{
    for (int i = 0; i < lenght; i++)
    {
        Console.Write("Enter {0} element: ", i + 1);
        while (true)
        {
            try
            {
                array.Add(int.Parse(Console.ReadLine()));
                break;
            }
            catch
            {
                Console.WriteLine("Wrong input! Please try again: ");
            }
        }
    }
}

int Input()
{
    int value;
    while (true)
    {
        try
        {
            value = int.Parse(Console.ReadLine());
            Console.WriteLine();
            return value;
        }
        catch
        {
            Console.Write("Wrong input! Please try again: ");
        }
    }
}

bool boolInput()
{
    bool value;
    while (true)
    {
        try
        {
            value = bool.Parse(Console.ReadLine());
            Console.WriteLine();
            return value;
        }
        catch
        {
            Console.Write("Wrong input! Please try again: ");
        }
    }
}