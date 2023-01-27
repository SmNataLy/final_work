string[] array;
Console.WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
array = stroka.Split(' ');
string[] newarray = new string[array.Length];
void FillArray(string[] array, string[] newarray)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newarray[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FillArray(array, newarray);
PrintArray(newarray);
