// 2 Написать программу преобразования десятичного числа в двоичное
/*void FillArray(int[] array) 
{
    int tmp = 0;
    int index = 0;
    int length = array.Length;
    while(index < length)
    {
        tmp = number % 2;
        number = number /2;
        array[index] = tmp;

        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}
*/


//Вариант 2
/*Console.WriteLine("Number?");
int number = int.Parse(Console.ReadLine());
int tmpnumber = number;
int tmp = 0;
int count = 0;
while(tmpnumber > 0)
    {
        tmp = tmpnumber % 2;
        tmpnumber = tmpnumber /2;
        count++;
    }

int[] array = new int[count];
FillArray(array);
PrintArray(array.Reverse().ToArray()); //Reverse array*/

//Вариант 3

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
int b = 0;
string result = " ";
//int result = 0;

while(a > 0)
{
    b = a % 2;
    result = b + result;
    a = a / 2;
  
}
Console.WriteLine(result);

// Вариант 4
/*Console.Write("Введите число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int Bit = Number % 2;
int NewNumber = Bit;
Number = Number / 2;
int i = 1;
while (Number > 0)
{
    Bit = Number % 2;
    Number = Number / 2;
    NewNumber = NewNumber + Bit * (int)Math.Pow(10,i);
    i++;
}
Console.WriteLine(NewNumber);*/

//Вариант 5
Console.Clear();
System.Console.WriteLine();
System.Console.Write("Введите число:   ");
string writeNum = Console.ReadLine();
int number = Convert.ToInt32(writeNum);

int[] ConvertToBinary(int num)
{
    int num2 = num;
    int size = 0;
    while (num > 0)
    {
        num = num / 2;
        size++;
    }

    int[] binary = new int[size];
    for (int i = size - 1; i >= 0; i--)
    {
        binary[i] = num2 % 2;
        num2 = num2 / 2;
    }
    return binary;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
    }
}

PrintArray(ConvertToBinary(number));