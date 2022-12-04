// Напишите программу, которая из имеющегося массива строк формирует массив из строк,
// длинна которых меньше или равна 3 лисвола
string[] array = new string[8] {"hello","hi","education",";-D","never","Moscow","po","1"};
string[] GetLessThanFour(string[] Array)
{
    int count = 0;
    for(int i  = 0; i < Array.Length; i++)
    {
        if(Array[i].Length < 4)
        {
            count++;
        }
    }
    Console.WriteLine(count);
    string[] lessThanFour = new string[count];
    count = 0;
    for(int j = 0; j < Array.Length; j++)
    {
        
        if(Array[j].Length < 4)
        {
            lessThanFour[count] = Array[j];
            count++;
        }
    }
    return lessThanFour;
}
string[] NewArray = GetLessThanFour(array);
Console.Write(String.Join(", ", NewArray));