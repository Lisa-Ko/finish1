string[] array1 ={"fggh", "2", "dfdh", "gf", "dfg", "3", "3)"};
string[] NewArrayWithIf(string[] array1)
{
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return array2;
}
void PrintArray(string[] array) 
{
    for (int i = 0; i < array.Length; i++)
    { 
        Console.Write(array[i]+ " ");
    }
    Console.WriteLine();
}
PrintArray(NewArrayWithIf(array1));
