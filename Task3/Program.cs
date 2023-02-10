void FillArray(int[]collection)
{
    int length=collection.Length;
    for (int index = 0; index < length; index++)
    {
        collection[index]=new Random().Next(1,100);
    }
}
int[] numbers = new int[10];
FillArray(numbers);
int[] numbersCopy=new int[numbers.Length];
int j=0;
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i]+" ");
    numbersCopy[j]=numbers[i];
    j++;
}
Console.WriteLine();
Console.WriteLine("Копия массива:");
for (int h = 0; h < numbersCopy.Length; h++)
{
    Console.Write(numbers[h]+" ");
}




