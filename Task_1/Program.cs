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

Task_1.Array array;
int lenght;
Init();

while (true)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine();
    Console.WriteLine("---Choose an option---");
    Console.WriteLine("1. Fill array");
    Console.WriteLine("2. Remove element by value");
    Console.WriteLine("3. Remove elemt by index");
    Console.WriteLine("4. Sort array");
    Console.WriteLine("5. Show array");
    Console.WriteLine("6. Show array with info");
    Console.WriteLine("7. Exit");
    Console.Write(">>>");

    string key = Console.ReadLine();
    switch (key)
    {
        case "1":
            Console.ForegroundColor = ConsoleColor.Green;
            FillArray();
            break;
        case "2":
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter value here: ");
            array.RemovebyValue(Input());
            break;
        case "3":
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Enter index here: ");
            removeByIndexChecking();
            break;
        case "4":
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            array.Sort();
            break;
        case "5":
            Console.ForegroundColor = ConsoleColor.Gray;
            array.Show();
            break;
        case "6":
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter info here: ");
            string info = Console.ReadLine();
            array.Show(info);
            break;
        case "7":
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

void removeByIndexChecking()
{
    try
    {
        array.RemoveByIndex(Input());
    }
    catch(ArgumentOutOfRangeException)
    {
        Console.WriteLine("index is out of range!");
    }
}